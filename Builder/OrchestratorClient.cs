using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Builder
{
    public class OrchestratorClient : IOrchestratorRequestBuilder
    {
        private static HttpClient _client;
        private Dictionary<string, string> _headers = new Dictionary<string, string>();
        private string _tenantName, _username, _password;
        private int _organizationUnitId;
        private Uri _baseUrl;
        private readonly Uri _loginUrl = new Uri("/api/Account/Authenticate", UriKind.Relative);

        public OrchestratorClient(HttpClient client)
        {
            _client = client;
        }

        private class AuthenticationObject
        {
            public string TenancyName
            {
                get; set;
            }
            public string UsernameOrEmailAddress
            {
                get; set;
            }

            public string Password
            {
                get; set;
            }
        }

        public IOrchestratorRequestBuilder WithHeaders(Dictionary<string, string> headers)
        {
            if (headers != null)
            {
                foreach (var item in headers)
                {
                    _headers.Add(item.Key, item.Value);
                }
            }
            return this;
        }

        public IOrchestratorRequestBuilder WithUrl(Uri baseUrl)
        {
            _baseUrl = baseUrl;
            return this;
        }

        public IOrchestratorRequestBuilder WithOrganizationUnitId(int organizationUnitId)
        {
            _headers["X-UIPATH-OrganizationUnitId"] = organizationUnitId.ToString();
            return this;
        }

        public IOrchestratorRequestBuilder WithBasicAuthentication(string tenantName,
            string username, string password)
        {
            _tenantName = tenantName;
            _username = username;
            _password = password;
            return this;
        }

        public async Task<T> Get<T>(Uri url, CancellationToken ct = default) where T : class
        {
            return await RequestAsync<T, T>(url, HttpMethod.Get, null, _headers, ct);
        }

        public async Task<List<T>> GetList<T>(Uri url, CancellationToken ct = default) where T : class
        {
            return await RequestAsync<List<T>, T>(url, HttpMethod.Get, null, _headers, ct);
        }

        public async Task<TResponse> Post<TRequest, TResponse>(Uri url, TRequest body,
            CancellationToken ct = default)
            where TResponse : class
            where TRequest : class
        {
            return await RequestAsync<TResponse, TRequest>(url, HttpMethod.Post, body, _headers);
        }

        public async Task<ApiResponse> LoginAsync(CancellationToken ct = default)
        {
            using (var content = SerializeContent<AuthenticationObject>(new AuthenticationObject
            {
                TenancyName = _tenantName,
                UsernameOrEmailAddress = _username,
                Password = _password,
            }))
            {
                using (var message = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri(_baseUrl, _loginUrl),
                    Content = content,
                })
                {
                    if (_headers != null)
                    {
                        foreach (var item in _headers)
                        {
                            message.Headers.Add(item.Key, item.Value);
                        }
                    }
                    var responseMessage = await _client.SendAsync(message, ct);
                    if (responseMessage.IsSuccessStatusCode == false)
                    {
                        throw new Exception("Authentification fails");
                    }
                    var apiResponse = await ReadBodyAndDeserialize<ApiResponse>(responseMessage);
                    _headers.Add("Authorization", "Bearer " + apiResponse.Result);
                    return apiResponse;
                }
            }
        }
        private async Task<T> ReadBodyAndDeserialize<T>(HttpResponseMessage responseMessage) where T : class
        {
            var responseBody = await responseMessage.Content.ReadAsStringAsync();
            return string.IsNullOrEmpty(responseBody) ? null : JsonConvert.DeserializeObject<T>(responseBody);
        }

        private async Task<T> RequestAsync<T, TBody>(Uri serviceUrl, HttpMethod method,
          TBody body, Dictionary<string, string> headers = null,
          CancellationToken ct = default)
          where T : class
        {
            var responseMessage = await RequestWithRetry(RequestAsync<TBody>, serviceUrl, method, body, headers, ct);
            return await ReadBodyAndDeserialize<T>(responseMessage);
        }

        private async Task<HttpResponseMessage> RequestAsync<TBody>(Uri serviceUrl, HttpMethod method,
            TBody body, Dictionary<string, string> headers = null, CancellationToken ct = default)
        {
            using (var message = new HttpRequestMessage
            {
                Method = method,
                RequestUri = new Uri(_baseUrl, serviceUrl),
                Content = SerializeContent<TBody>(body),
            })
            {
                if (headers != null)
                {
                    foreach (var item in headers)
                    {
                        message.Headers.Add(item.Key, item.Value);
                    }
                }
                return await _client.SendAsync(message, ct);
            }
        }

        public async Task<HttpResponseMessage> UploadPackage(Uri serviceUrl, string fileName, CancellationToken ct = default)
        {
            using (var file = File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var streamContent = new StreamContent(file))
                {
                    var multipart = new MultipartFormDataContent
                    {
                        { streamContent, "file", file.Name }
                    };

                    using (var message = new HttpRequestMessage
                    {
                        Method = HttpMethod.Post,
                        RequestUri = new Uri(_baseUrl, serviceUrl),
                        Content = multipart,
                    })
                    {
                        if (_headers != null)
                        {
                            foreach (var item in _headers)
                            {
                                message.Headers.Add(item.Key, item.Value);
                            }
                        }
                        var responseMessage = await _client.SendAsync(message, ct);
                        Console.WriteLine((int)responseMessage.StatusCode);
                        return responseMessage;
                    }
                }
            }
        }

        public async Task<HttpResponseMessage> DownloadPackage(string serviceUrl, string fileName,
            string key, CancellationToken ct = default)
        {
            serviceUrl = $"{serviceUrl}(key='{key}')";

            var relativeUrl = new Uri(serviceUrl, UriKind.Relative);
            using (var message = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(_baseUrl, relativeUrl),
            })
            {
                foreach(var item in _headers)
                {
                    message.Headers.Add(item.Key, item.Value);
                }

                using (var responseMessage = await _client.SendAsync(message, HttpCompletionOption.ResponseHeadersRead, ct))
                {
                    if (responseMessage.IsSuccessStatusCode == false)
                    {
                        throw new Exception("Server Error");
                    }
                    using (var stream = await responseMessage.Content.ReadAsStreamAsync())
                    {
                        using (var fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                        {
                            await stream.CopyToAsync(fileStream);
                        }
                    }
                    return responseMessage;
                }
            }
        }

        public async Task<HttpResponseMessage> RequestWithRetry<TBody>(Func<Uri, HttpMethod, TBody,
            Dictionary<string, string>, CancellationToken, Task<HttpResponseMessage>> request, Uri serviceUrl,
            HttpMethod method, TBody body, Dictionary<string, string> headers = null,
            CancellationToken ct = default)
        {
            var responseMessage = await request(serviceUrl, method, body, headers, ct);
            if (responseMessage.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                var login = await LoginAsync();
                headers["Authorization"] = "Bearer " + login.Result;
                responseMessage = await request(serviceUrl, method, body, headers, ct);
                if (responseMessage.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    throw new Exception("Can't login");
                }
            }
            if (responseMessage.IsSuccessStatusCode == false)
            {
                throw new ApiException
                {
                    StatusCode = (int)responseMessage.StatusCode,
                };
            }
            return responseMessage;
        }

        private HttpContent SerializeContent<T>(T payload)
        {
            var json = JsonConvert.SerializeObject(payload);
            var stringContent = new StringContent(json);
            stringContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return stringContent;
        }

    }
}
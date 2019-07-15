using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Builder
{
    public class OrchestratorClient : IOrchestratorRequestBuilder
    {
        private readonly HttpClient _client = new HttpClient();
        private Dictionary<string, string> _headers = new Dictionary<string, string>();
        private string _tenantName, _username, _password;
        private int _organizationUnitId;
        private Uri _baseUrl;
        private readonly Uri _loginUrl = new Uri("/api/Account/Authenticate", UriKind.Relative);

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
            return await RequestAsync<T>(url, HttpMethod.Get, null, _headers, ct);
        }

        public async Task<List<T>> GetList<T>(Uri url, CancellationToken ct = default) where T : class
        {
            return await RequestAsync<List<T>>(url, HttpMethod.Get, null, _headers, ct);
        }

        public async Task<TResponse> Post<TRequest, TResponse>(Uri url, TRequest body,
            CancellationToken ct = default)
            where TResponse : class
            where TRequest : class
        {
            using (var content = SerializeContent<TRequest>(body))
            {
                return await RequestAsync<TResponse>(url, HttpMethod.Post, content, _headers);
            }
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
                var responseMessage = await CreateAndSendMessage(_loginUrl, HttpMethod.Post, content, _headers, ct);
                return await ReadBodyAndDeserialize<ApiResponse>(responseMessage);
            }
        }

        private async Task<HttpResponseMessage> CreateAndSendMessage(Uri url, HttpMethod method,
           HttpContent content, Dictionary<string, string> headers = null,
           CancellationToken ct = default)
        {
            using (var message = new HttpRequestMessage
            {
                Method = method,
                RequestUri = new Uri(_baseUrl, url),
                Content = content,
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

        private async Task<T> ReadBodyAndDeserialize<T>(HttpResponseMessage responseMessage) where T : class
        {
            var responseBody = await responseMessage.Content.ReadAsStringAsync();
            return string.IsNullOrEmpty(responseBody) ? null : JsonConvert.DeserializeObject<T>(responseBody);
        }

        private async Task<T> RequestAsync<T>(Uri serviceUrl, HttpMethod method,
          HttpContent content, Dictionary<string, string> headers = null,
          CancellationToken ct = default)
          where T : class
        {
            var responseMessage = await RequestAsync(serviceUrl, method, content, headers, ct);
            return await ReadBodyAndDeserialize<T>(responseMessage);
        }

        private async Task<HttpResponseMessage> RequestAsync(Uri serviceUrl, HttpMethod method,
            HttpContent content, Dictionary<string, string> headers = null,
            CancellationToken ct = default, bool loginAndRetry = true)
        {
            var responseMessage = await CreateAndSendMessage(serviceUrl, method, content, headers, ct);
            if (responseMessage.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                if (loginAndRetry)
                {
                    var login = await LoginAsync();
                    headers["Authorization"] = "Bearer " + login.Result;
                    return await RequestAsync(serviceUrl, method, content, headers, ct, false);
                }
                else
                {
                    throw new Exception("Authentification fails");
                }
            }

            if(responseMessage.IsSuccessStatusCode == false)
            {
                throw new ApiException
                {
                    StatusCode = (int)responseMessage.StatusCode,
                };
            }

            return responseMessage;
        }

        private StringContent SerializeContent<T>(T payload)
        {
            var json = JsonConvert.SerializeObject(payload);
            var stringContent = new StringContent(json);
            stringContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return stringContent;
        }
    }
}

























































































































































































































































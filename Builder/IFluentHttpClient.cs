using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Builder
{
    public interface IFluentHttpClient<T>
    {
        T WithHeaders(Dictionary<string, string> headers);
        T WithBasicAuthentication(string tenantName, string username,
            string password);

        T WithUrl(Uri baseUrl);
        Task<T> Get<T>(Uri url, CancellationToken ct = default) where T : class;
        Task<List<T>> GetList<T>(Uri url, CancellationToken ct = default)
            where T : class;
        Task<TResponse> Post<TRequest, TResponse>(Uri url, TRequest body,
            CancellationToken ct = default)
            where TRequest : class
            where TResponse : class;
        Task<ApiResponse> LoginAsync(CancellationToken ct);
    }
}

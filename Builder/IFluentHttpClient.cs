using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Builder
{
    public interface IFluentHttpClient<IFluentHttpClientDerived>
        where IFluentHttpClientDerived : IFluentHttpClient<IFluentHttpClientDerived>
    {
        IFluentHttpClientDerived WithHeaders(Dictionary<string, string> headers);

        IFluentHttpClientDerived WithBasicAuthentication(string tenantName, string username,
            string password);

        IFluentHttpClientDerived WithUrl(Uri baseUrl);

        Task<T> Get<T>(Uri url, CancellationToken ct = default) where T : class;

        Task<List<T>> GetList<T>(Uri url, CancellationToken ct = default)
            where T : class;

        Task<TResponse> Post<TRequest, TResponse>(Uri url, TRequest body,
            CancellationToken ct = default)
            where TRequest : class
            where TResponse : class;

        Task<ApiResponse> LoginAsync(CancellationToken ct = default);
    }
}

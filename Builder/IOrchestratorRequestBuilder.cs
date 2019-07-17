using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Builder
{
    public interface IOrchestratorRequestBuilder :
        IFluentHttpClient<IOrchestratorRequestBuilder>
    {
        IOrchestratorRequestBuilder WithOrganizationUnitId(int organizationUnitId);

        Task<HttpResponseMessage> UploadPackage(Uri serviceUrl, string fileName, CancellationToken ct = default);

        Task<HttpResponseMessage> DownloadPackage(string serviceUrl, string fileName,
            string key, CancellationToken ct = default);
    }
}

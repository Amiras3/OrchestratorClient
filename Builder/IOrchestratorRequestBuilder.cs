using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface IOrchestratorRequestBuilder :
        IFluentHttpClient<IOrchestratorRequestBuilder>
    {
        IOrchestratorRequestBuilder WithOrganizationUnitId(int organizationUnitId);
    }
}

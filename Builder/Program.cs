using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Builder
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var headers = new Dictionary<string, string> {
                {"Accept", "application/json"}
            };

            var client = new OrchestratorClient()
                .WithOrganizationUnitId(1)
                .WithUrl(new Uri("http://localhost:6234/"))
                .WithBasicAuthentication("default", "admin", "890iop")
                .WithHeaders(headers);

            var result = await client.Get<ODataResponse>(new Uri("/odata/Users", UriKind.Relative));

            foreach (var item in result.Value)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}

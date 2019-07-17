using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var headers = new Dictionary<string, string>();

            var orchestratorClient = new OrchestratorClient(client).
                   WithBasicAuthentication("default", "admin", "890iop").
                   WithUrl(new Uri("http://localhost:6234/")).
                   WithHeaders(headers);

            var resultLogin = await orchestratorClient.LoginAsync();
            Console.WriteLine(resultLogin.Result);
            var response = await orchestratorClient.DownloadPackage
                ("/odata/Processes/UiPath.Server.Configuration.OData.DownloadPackage"
                , @"C:\Users\amir.zamfiratos\Desktop\Hello111.nupkg"
                , "Hello:1.0.6418.26873");


        }
    }
}

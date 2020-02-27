using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using WorkshopLSLTests.WebApp;

namespace WorkshopLSLTests.IntegrationsTest.Fixtures
{
    public class TestContext
    {
        public HttpClient Client { get; set; }
        private TestServer _server;
        public TestContext()
        {
            this.SetupClient();
        }

        private void SetupClient()
        {
            //Assume configurações do startup do nosso projeto WebApp
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            //Cria cliente da instancia atual do server construído
            Client = _server.CreateClient();
        }
    }
}

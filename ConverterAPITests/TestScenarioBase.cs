using System;
using Xunit;
using ConverterAPI;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace ConverterAPITests
{
    public class TestScenarioBase
    {
        public TestServer CreateServer()
        {
            var webHostBuilder = WebHost.CreateDefaultBuilder();
            webHostBuilder.UseStartup<Startup>();
            var testServer = new TestServer(webHostBuilder);

            return testServer;
        }
    }
}

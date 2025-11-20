using JetBrains.Annotations;
using MartinCostello.Logging.XUnit;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace WebApiSample.IntegrationTest.Fixture;

[UsedImplicitly]
public class IntegrationTestFixture : WebApplicationFactory<Program>, ITestOutputHelperAccessor
{
    public ITestOutputHelper? OutputHelper { get; set; }

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureLogging(logging =>
        {
            logging.ClearProviders();
            logging.AddXUnit(this);
            logging.SetMinimumLevel(LogLevel.Debug);
        });
        builder.UseEnvironment("Development");
    }
}
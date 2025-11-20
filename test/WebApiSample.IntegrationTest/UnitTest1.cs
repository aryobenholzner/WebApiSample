using WebApiSample.IntegrationTest.Fixture;
using Xunit.Abstractions;

namespace WebApiSample.IntegrationTest;

public class SampleIT(IntegrationTestFixture fixture, ITestOutputHelper output) : BaseIT(fixture, output)
{
    [Fact]
    public async Task SampleTest()
    {
        var response = await HttpClient.GetAsync($"v1/pets/0");
        
        Assert.True(response.IsSuccessStatusCode);
    }
}
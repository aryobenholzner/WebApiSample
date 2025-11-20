using Xunit.Abstractions;

namespace WebApiSample.IntegrationTest.Fixture;

[Collection(nameof(IntegrationTests))]
public abstract class BaseIT
{

    protected HttpClient HttpClient { get; private set; }

    protected BaseIT(IntegrationTestFixture fixture, ITestOutputHelper output)
    {
        fixture.OutputHelper = output;
        HttpClient = fixture.CreateClient();
    }
}
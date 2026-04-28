namespace Mureka.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static MurekaClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("MUREKA_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("MUREKA_API_KEY environment variable is not found.");

        var client = new MurekaClient(apiKey);
        
        return client;
    }
}

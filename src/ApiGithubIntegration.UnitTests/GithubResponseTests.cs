using cli_api_github_integration.Resources;
using FluentAssertions;

namespace ApiGithubIntegration.UnitTests;

public class GithubResponseTests
{
    [Fact]
    public async Task GitHubResponse_ShouldProviderAllAttribute_WhenInitialized()
    {
        var gitHubResponse = new GitHubResponse
        {
            Id = Guid.NewGuid().ToString(),
            Description = "some description just for testing it.",
            Name = "just a test"
        };
        gitHubResponse.Id.Should().NotBeNullOrEmpty();
        gitHubResponse.Description.Should().NotBeNullOrEmpty();
        gitHubResponse.Name.Should().NotBeNullOrEmpty();
    }
    
}
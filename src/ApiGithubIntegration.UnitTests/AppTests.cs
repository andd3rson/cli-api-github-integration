using cli_api_github_integration;
using cli_api_github_integration.Interfaces;
using cli_api_github_integration.Resources;
using FluentAssertions;
using NSubstitute;

namespace ApiGithubIntegration.UnitTests;

public class AppTests
{
    [Fact]
    public async Task RunAsync_ShouldInvokeGithubService_WhenMethodIsCalling()
    {
        //arrange
        string[] args = new[] { "-u", "andd3rson" };
        var githubServices = Substitute.For<IGithubServices>();
        var response = new Response<IEnumerable<GitHubResponse>>(new List<GitHubResponse>(), true);
        githubServices.GetRepos(Arg.Any<string>()).Returns(response);

        var app = Substitute.For<App>(githubServices);

        //action 
        await app.Run(args);
        //assert
        await githubServices.Received(1).GetRepos(Arg.Any<string>());
    }
    
}
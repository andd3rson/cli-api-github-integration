using cli_api_github_integration;
using cli_api_github_integration.Interfaces;
using cli_api_github_integration.Resources;
using cli_api_github_integration.Services;
using FluentAssertions;
using Moq;

namespace ApiGithubIntegration.UnitTests.Services;

public class GithubServicesTests
{
    
    [Fact]
    public async Task GetRepos_ShouldReturnSuccess_WhenUserExists()
    {
        // Arrange
        string userName = "andd33rson";
        var sut = new Mock<IGithubServices>();

        sut.Setup(m => m.GetRepos(userName))
            .ReturnsAsync(new Response<IEnumerable<GitHubResponse>>(new List<GitHubResponse>(), true));

        // Action
        var result = await sut.Object.GetRepos(userName);

        //Assert
        result.IsSuccess.Should().BeTrue();

    }
 }
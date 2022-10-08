using cli_api_github_integration;
using cli_api_github_integration.Interfaces;
using cli_api_github_integration.Resources;
using cli_api_github_integration.Services;
using FluentAssertions;
using Moq;
using NSubstitute;
using Refit;

namespace ApiGithubIntegration.UnitTests.Services;

public class GithubServicesTests
{
    private readonly IGithubSearch _githubSearch;

    public GithubServicesTests()
    {
        var http = new HttpClient
        {
            BaseAddress = new Uri("https://api.github.com"),
            DefaultRequestHeaders = { { "User-Agent", "Refit" } }
        };
        _githubSearch = RestService.For<IGithubSearch>(http);
    }

    [Fact]
    public async Task GetRepos_ShouldReturnSuccess_WhenUserExists()
    {
        // Arrange
        string userName = "andd3rson";
        var sut = new GithubServices(_githubSearch);
        // Action
        var result = await sut.GetRepos(userName);
        //Assert
        result.IsSuccess.Should().BeTrue();
        result.Data.Should().BeOfType<List<GitHubResponse>>();
    }

    [Fact]
    public async Task GetRepos_ShouldReturnFalse_WhenNotFoundUser()
    {
        // Arrange
        string userName = "valid@3ashkxlmas";
        var sut = new GithubServices(_githubSearch);
        // Action
        var result = await sut.GetRepos(userName);
        //Assert
        result.IsSuccess.Should().BeFalse();
    }

    [Fact]
    public async Task GetRepo_ShouldVerifyGithubSearch_WhenIsCalled()
    {
        // Arrange
        string userName = "kxlmas";
        var githubSearch = Substitute.For<IGithubSearch>();
        var sut = new GithubServices(githubSearch);
        // Action
        var result = await sut.GetRepos(userName);
        await githubSearch.Received(1).GetUserRepositories(userName);
    }
}
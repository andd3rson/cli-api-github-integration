using cli_api_github_integration.Interfaces;
using cli_api_github_integration.Resources;

namespace cli_api_github_integration.Services;

public class GithubServices : IGithubServices
{
    private readonly IGithubSearch _githubSearch;

    public GithubServices(IGithubSearch githubSearch)
    {
        _githubSearch = githubSearch;
    }
    public async Task<Response<IEnumerable<GitHubResponse>>> GetRepos(string username)
    {
        var request = await _githubSearch.GetUserRepositories(username);
        return new Response<IEnumerable<GitHubResponse>>(request, request.Any());
    }
}
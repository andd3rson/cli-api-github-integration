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
    public async Task<IEnumerable<GitHubResponse>> Get(string username)
    {
        return await _githubSearch.GetUserRepositories(username);
        
    }
}
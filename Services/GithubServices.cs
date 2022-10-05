using cli_api_github_integration.Interfaces;
using cli_api_github_integration.Models;

namespace cli_api_github_integration.Services;

// https://api.github.com/users/{username}/repos
public class GithubServices : IGithubServices
{
    public Task<List<GitHubResponse>> GetUserRepositories(string userName)
    {
        throw new NotImplementedException();
    }
}
using cli_api_github_integration.Models;

namespace cli_api_github_integration.Interfaces;

public interface IGithubServices
{
    Task<List<GitHubResponse>> GetUserRepositories(string userName);
}
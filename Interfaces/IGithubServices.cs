using cli_api_github_integration.Models;
using Refit;

namespace cli_api_github_integration.Interfaces;

public interface IGithubServices
{
    [Get("users/username/repos")]
    Task<List<GitHubResponse>> GetUserRepositories(string userName);
}
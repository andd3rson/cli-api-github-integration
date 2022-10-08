using cli_api_github_integration.Resources;

namespace cli_api_github_integration.Interfaces;

public interface IGithubServices
{
    Task<Response<IEnumerable<GitHubResponse>>> GetRepos(string username);
}
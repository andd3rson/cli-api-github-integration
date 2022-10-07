using cli_api_github_integration.Resources;

namespace cli_api_github_integration.Interfaces;

public interface IGithibServices
{
    Task<IEnumerable<GitHubResponse>> Get(string username);
}
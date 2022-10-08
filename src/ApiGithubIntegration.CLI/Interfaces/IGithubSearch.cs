using cli_api_github_integration.Resources;
using Refit;

namespace cli_api_github_integration.Interfaces;

public interface IGithubSearch
{
    [Get("/users/{userName}/repos")]
    Task<IEnumerable<GitHubResponse>> GetUserRepositories(string userName);
    
    
    
}
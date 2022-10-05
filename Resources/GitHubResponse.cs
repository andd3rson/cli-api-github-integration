using System.Text.Json.Serialization;

namespace cli_api_github_integration.Models;


public class GitHubResponse
{
    [JsonPropertyName("html_url")]
    public string HtmlUrl { get; set; }
    
    [JsonPropertyName("description")]
    public string Description { get; set; }
}
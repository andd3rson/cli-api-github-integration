using System.Text.Json.Serialization;

namespace cli_api_github_integration.Resources;
public class GitHubResponse
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("description")]
    public string Description { get; set; }
}
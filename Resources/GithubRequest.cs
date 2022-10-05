using CommandLine;

namespace cli_api_github_integration.Models;

public class GithubRequestModel
{
    [Option('u', "username", Required = true, HelpText = "Should provider a username for searching.")]
    public string UserName { get; init; }
}
using CommandLine;

namespace cli_api_github_integration.Resources;

public class GithubRequestModel
{
    [Option('u', "username", Required = true, HelpText = "Should provider a username for searching it.")]
    public string UserName { get; init; }
}
using CommandLine;
using CommandLine.Text;

namespace CliApiGithubIntegration;

public class App
{
    public void Run(string[] args)
    {
        var parserResult = Parser
            .Default
            .ParseArguments<GithubRequestModel>(args)
            .WithParsed(name =>
            {
                
            });
    }
}

public class GithubRequestModel
{
    [Option('u', "username", Required = true, HelpText = "Should provider a username for searching.")]
    public string UserName { get; set; }
}
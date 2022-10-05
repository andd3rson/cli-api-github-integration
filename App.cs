using System.Text.Json;
using cli_api_github_integration.Interfaces;
using cli_api_github_integration.Models;
using CommandLine;

namespace cli_api_github_integration;

public class App
{
    private readonly IGithubServices _githubServices;

    public App(IGithubServices githubServices)
    {
        _githubServices = githubServices;
    }
    public void Run(string[] args)
    {
        var parserResult = Parser
            .Default
            .ParseArguments<GithubRequestModel>(args)
            .WithParsed(name =>
            {
                var obj = JsonSerializer.Serialize(name);
                Console.WriteLine(obj);
            });
    }
}
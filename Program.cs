using cli_api_github_integration.Interfaces;
using cli_api_github_integration.Services;
using Microsoft.Extensions.DependencyInjection;

namespace cli_api_github_integration
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var serviceCollection = ServiceCollection();
            var buildServiceProvider = serviceCollection.BuildServiceProvider();
            var app = buildServiceProvider.GetRequiredService<App>();
            app.Run(args);
        }

        private static ServiceCollection ServiceCollection()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<App>();
            serviceCollection.AddScoped<IGithubServices, GithubServices>();
            return serviceCollection;
        }
    }
}
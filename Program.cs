using cli_api_github_integration.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace cli_api_github_integration
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var serviceCollection = ServiceCollection();
            var buildServiceProvider = serviceCollection.BuildServiceProvider();
            var app = buildServiceProvider.GetRequiredService<App>();
            await app.Run(args);
        }

        private static ServiceCollection ServiceCollection()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<App>();
            // serviceCollection.AddScoped<IGithubServices, GithubServices>();
            serviceCollection.AddRefitClient<IGithubServices>()
                .ConfigureHttpClient(config =>
                {
                    config.DefaultRequestHeaders.Add("User-Agent", "request");
                    config.BaseAddress = new Uri("https://api.github.com");
                    
                });
            return serviceCollection;
        }
    }
}
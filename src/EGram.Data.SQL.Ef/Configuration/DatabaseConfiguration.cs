using System;
using EGram.Data.SQL.Ef.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EGram.Data.SQL.Ef.Configuration
{
    public static class DatabaseConfiguration
    {
        private static IConfiguration Configuration { get; set; }

        public static void AddDatabaseConfiguration(this IServiceCollection services)
        {
            //Read Configuration
            var configurationBuilder = new ConfigurationBuilder();

            var builderConfig = configurationBuilder
                .SetBasePath(Environment.CurrentDirectory)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true);

            Configuration = builderConfig.Build();

            services.AddDbContext<Context>(options =>
            options.UseSqlServer(Configuration.GetConnectionString($"EGramContext.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}"),
            //Implementing resilient Entity Framework Core SQL connections
            //Read more https://bit.ly/2KBzXia
            sqlServerOptionsAction: sqlOptions =>
            {
                sqlOptions.EnableRetryOnFailure(
                maxRetryCount: 5,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null);
            }));
        }
    }
}

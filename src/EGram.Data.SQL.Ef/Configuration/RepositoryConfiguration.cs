using System;
using EGram.Data.EF.Repositories.SurveyRepositories;
using EGram.Data.SQL.Ef.Repositories;
using EGram.Data.SQL.Ef.Repositories.EducationRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace EGram.Data.SQL.Ef.Configuration
{
	public static class RepositoryConfiguration
    {
        public static void AddRepositoryConfiguration(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ISurveyRepository, SurveyRepository>();
            services.AddTransient<IEducationRepository, EducationRepository>();
            services.AddTransient<IServiceCollection, ServiceCollection>();
        }
    }
}

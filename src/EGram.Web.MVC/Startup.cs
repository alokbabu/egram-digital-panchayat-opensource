﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EGram.Data.EF.Repositories;
using EGram.Data.EF.Repositories.SurveyRepositories;
using EGram.Data.SQL.Ef.Configuration;
using EGram.Data.SQL.Ef.Contexts;
using EGram.Data.SQL.Ef.Identity.Models;
using EGram.Data.SQL.Ef.Repositories;
using EGram.Data.SQL.Ef.Repositories.EducationRepositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EGram.Web.MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDatabaseConfiguration();
            services.AddRepositoryConfiguration();

            //ASP.NET Core identity
            services.AddIdentity<ApplicationUser, IdentityRole<Guid>>()
                        .AddEntityFrameworkStores<EGramContext>()
                        .AddDefaultUI()
                        .AddDefaultTokenProviders();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

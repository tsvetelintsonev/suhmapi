using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SuhMapi.Core.Api.Repositories.Mongo;
using SuhMapi.Core.Api.Repositories.Mongo.Startups;
using SuhMapi.Core.Api.Services;
using SuhMapi.Core.Repositories.Mongo.Startups;
using SuhMapi.WebApi.Settings;

namespace WebApi
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
            AppSettings appSettings = new AppSettings();

            Configuration.Bind(appSettings);

            services.AddMvc();

            // Register AppSettings
            services.AddSingleton<AppSettings>(appSettings);

            // Register internal services
            services.AddTransient<IStartupsService, StartupsService>();

            // Register internal repositories
            services.AddSingleton<IMongoDatabase>(new MongoClient(appSettings.ConnectionStrings.MongoDb)
            .GetDatabase(new MongoUrl(appSettings.ConnectionStrings.MongoDb).DatabaseName));

            services.AddTransient<IStartupsRepository, StartupsRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}

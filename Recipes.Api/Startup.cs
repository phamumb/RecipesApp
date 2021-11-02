
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Pomelo.EntityFrameworkCore.MySql;
using Recipes.Repository;
using Recipes.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Recipes.Logic;
using System;

namespace Recipes.Api
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
            var dbServerVersion = new MySqlServerVersion(new Version(8, 0, 26));
            services.AddDbContext<Repository.Context.AppContext>(options => 
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection"), dbServerVersion)
                    .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableSensitiveDataLogging()
            );
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Recipes.Api", Version = "v1" });
            });
            services.AddLogic();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Recipes.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

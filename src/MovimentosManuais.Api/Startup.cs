using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovimentosManuais.InfraStruture.Data;

namespace MovimentosManuais.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);            

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                                  policy =>
                                  {
                                      policy.WithOrigins("http://localhost",
                                                          "https://localhost")
                                                    .AllowAnyHeader()
                                                    .AllowAnyMethod()
                                                    .AllowAnyOrigin();
                                  });
            });

            services.AddDbContext<MovimentosManuaisContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DataBaseConnection")));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseCors();

        }
    }
}

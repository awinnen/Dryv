using System.Text.Json;
using System.Text.Json.Serialization;
using Dryv.AspNetCore;
using Dryv.SampleVue.CustomValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dryv.SampleVue
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    "home",
                    "/",
                    new { controller = "Home", action = "Index" });
            });

            app.UseDryv();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
            services
                .AddMvc(options =>
                {
                    options.EnableEndpointRouting = true;
                })
                .AddRazorRuntimeCompilation()
                .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)))
                .AddDryv()
                .AddDryvDynamicControllers()
                .AddDryvPreloading();

            services.AddSingleton<AsyncValidator>();
            services.AddSingleton<SyncValidator>();
            services.AddOptions<SampleOptions>();
        }
    }
}
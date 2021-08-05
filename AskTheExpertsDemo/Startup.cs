using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AskTheExpertsDemo;
using AskTheExpertsDemo.Infastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Routing;
using Kentico.Forms.Web.Mvc;

namespace BlankSiteCore
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Ensures redirect to the administration instance based on URL defined in settings
            //services.AddSingleton<IStartupFilter>(new AdminRedirectStartupFilter(Configuration));

            var kenticoServiceCollection = services.AddKentico(features =>
            {
                features.UsePageBuilder();
                // features.UseActivityTracking();
                // features.UseABTesting();
                // features.UseWebAnalytics();
                // features.UseEmailTracking();
                // features.UseCampaignLogger();
                // features.UseScheduler();
                features.UsePageRouting();
            });

            if (Environment.IsDevelopment())
            {
                kenticoServiceCollection.SetAdminCookiesSameSiteNone();
                kenticoServiceCollection.DisableVirtualContextSecurityForLocalhost();
            }

            services.AddSingleton<RepositoryCacheHelper>();

            services.Configure<RouteOptions>(options => options.LowercaseUrls = true);
            services.AddControllersWithViews();

            services.Configure<FormBuilderBundlesOptions>(options =>
            {
                options.JQueryCustomBundleWebRootPath = "Scripts/jquery-3.5.1.min.js";
                options.JQueryUnobtrusiveAjaxCustomBundleWebRootPath = "Scripts/jquery.unobtrusive-ajax.min.js";
            });

            services.AddAuthentication();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {

                app.UseDeveloperExceptionPage();
            }

            FormBuilderCustomizations.SetGlobalRenderingConfigurations();

            app.UseStaticFiles();

            app.UseKentico();

            app.UseCookiePolicy();

            app.UseCors();

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.Kentico().MapRoutes();

                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller}/{action}",
                    defaults: new { controller = "Home", action = "Index" }
                );
            });
        }
    }

}

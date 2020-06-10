using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using HYPJ.Web.Core.Middleware;
using HYPJ.Web.Core.Filter;
using HYPJ.Utilities.Extension;
using HYPJ.Web.Core.Extensions;
using Microsoft.Extensions.Configuration;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HypjCms.Web
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
            services.AddMvc(options =>
                options.Filters.Add<ModelStateValidFilter>());

            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.Cookie.IsEssential = true;
                options.IdleTimeout = TimeSpan.FromSeconds(7200);
            });
            services.AddHttpContextAccessor();
            services.AddWebCore(Configuration);

            //AutoMapper
            services.AddAutoMapper(map => map.AddProfiles(GetType().Assembly));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseStaticHttpContext();
            app.UseErrorHandler();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=admin}/{action=Index}/{id?}");
            });
        }
    }
}

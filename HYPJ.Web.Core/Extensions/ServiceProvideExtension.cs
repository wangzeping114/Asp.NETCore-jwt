using HYPJ.Infrastructure;
using HYPJ.Web.Core.Configs;
using HYPJ.Web.Core.ServiceCollectionModule;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Serilog;
namespace HYPJ.Web.Core.Extensions
{
    public static class ServiceProvideExtension
    {

        public static IServiceCollection AddWebCore(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddLogging(b =>
            {
                b.ClearProviders();
                b.AddSerilog(new LoggerConfiguration()
                    .ReadFrom.ConfigurationSection(configuration.GetSection("Logging"))
                    .Enrich.FromLogContext()
                    .CreateLogger());
            });

            services.Configure<SiteConfig>(configuration.GetSection("SiteConfig"));
            //json配置 Newtonsoft.New
            services.Configure<MvcJsonOptions>(options =>
            {
                //忽略循环引用
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                //设置时间格式
                options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
                //使用驼峰样式的key
                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            });

            //数据库连接
            var conn = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<StarCloudDbContext>(options => options.UseSqlServer(conn, b => b.UseRowNumberForPaging()));
            services
              .RegisterModule(new RepositoryModule())
              .RegisterModule(new ServiceModule())
              .RegisterModule(new PropertyMappingModule())
              .RegisterModule(new HandlerModule());
            return services;
        }

        public static IServiceCollection RegisterModule(this IServiceCollection services, IServiceModule module)
        {
            return module.Register(services);
        }
    }
}

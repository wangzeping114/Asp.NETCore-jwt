using HYPJ.Applicatoin.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HYPJ.Web.Core.ServiceCollectionModule
{
    public class ServiceModule : IServiceModule
    {
        public IServiceCollection Register(IServiceCollection services)
        {
            services.AddScoped<PassportService>();

            return services;
        }
    }
}

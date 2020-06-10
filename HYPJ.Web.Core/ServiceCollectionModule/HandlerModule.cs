using HYPJ.Applicatoin.Handler;
using Microsoft.Extensions.DependencyInjection;

namespace HYPJ.Web.Core.ServiceCollectionModule
{
    public class HandlerModule : IServiceModule
    {
        public IServiceCollection Register(IServiceCollection services)
        {
            services.AddScoped<IPasswordHandler, PasswordHandler>();
            return services;
        }
    }
}

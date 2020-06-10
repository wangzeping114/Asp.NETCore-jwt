using HYPJ.Core.Repositories;
using HYPJ.Infrastructure.Respositories;
using Microsoft.Extensions.DependencyInjection;

namespace HYPJ.Web.Core.ServiceCollectionModule
{
    public class RepositoryModule : IServiceModule
    {
        public IServiceCollection Register(IServiceCollection services)
        {
            services.AddScoped<IAccountRespository, AccountRepository>();
            services.AddScoped<IRoleRespository, RoleRepository>();
            services.AddScoped<IMenuRespository, MenuRespository>();
            return services;
        }
    }
}

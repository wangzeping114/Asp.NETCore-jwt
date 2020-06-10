using HYPJ.Applicatoin.Resources;
using HYPJ.Core.Entites;
using HYPJ.Core.Paging.PropertyMapping;
using Microsoft.Extensions.DependencyInjection;
namespace HYPJ.Web.Core.ServiceCollectionModule
{
    public class PropertyMappingModule : IServiceModule
    {
        public IServiceCollection Register(IServiceCollection services)
        {
            var container = new PropertyMappingContainer();
            container.Register<AccountResource, Account, int>();
            container.Register<SysOperatorResource, Account, int>();
            container.Register<RoleResource, Role, int>();
            container.Register<MenuResource, Menu, int>();
            services.AddSingleton<IPropertyMappingContainer>(container);
            return services;
        }
    }
}

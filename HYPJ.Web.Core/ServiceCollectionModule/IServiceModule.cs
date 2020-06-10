using Microsoft.Extensions.DependencyInjection;

namespace HYPJ.Web.Core.ServiceCollectionModule
{
    public interface IServiceModule
    {
        IServiceCollection Register(IServiceCollection services);
    }
}

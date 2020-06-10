using System.Threading.Tasks;

namespace HYPJ.Core.SeedWorks
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChangesAsync();
    }
}

using HYPJ.Core.Entites;
using HYPJ.Core.SeedWorks;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HYPJ.Core.Repositories
{
    public interface IMenuRespository : IRepository<Menu, int>
    {
        Task<Menu> GetParentMenu(int parentId);

        Task<List<Menu>> GetAllMenus();

        Task<List<Menu>> GetMenuByRole(int RoleId);
    }
}

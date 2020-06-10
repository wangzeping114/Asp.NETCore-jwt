using HYPJ.Core.Entites;
using HYPJ.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HYPJ.Infrastructure.Respositories
{
    public class MenuRespository : BaseRepository<Menu, int>, IMenuRespository
    {
        public MenuRespository(StarCloudDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<List<Menu>> GetAllMenus()
        {
            var allentites =await Entities.Include(x => x.Children).Where(x => x.Parent == null).ToListAsync();
            return  allentites;
        }

        public async Task<List<Menu>> GetMenuByRole(int RoleId)
        {
            return await Entities.Include(c=>c.Children)
                 .Where(c=>c.RoleMenus.Any(x=>x.RoleId==RoleId)&&c.Parent==null)
                 .Select(t => new Menu
                 {
                        Id = t.Id,
                        Children = t.Children.Where(c => c.RoleMenus.Any(x => x.RoleId == RoleId)).ToList(),
                        Name = t.Name,
                        ActionSref = t.ActionSref,
                        Icon = t.Icon
                  }).ToListAsync();
        }


        public async Task<Menu> GetParentMenu(int parentId)
        {
            var entity = await Task.Run(() => Entities.Include(x => x.Children).Where(x => x.Id == parentId).First());
            return entity;
        }
     } 
}

using HYPJ.Core.Entites;
using HYPJ.Core.Repositories;

namespace HYPJ.Infrastructure.Respositories
{
    public class RoleRepository : BaseRepository<Role, int>, IRoleRespository
    {
        public RoleRepository(StarCloudDbContext dbContext) : base(dbContext)
        {
        }
    }
}

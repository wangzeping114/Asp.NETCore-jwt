using HYPJ.Core.Entites;
using HYPJ.Core.Paging.PropertyMapping;
using HYPJ.Core.Repositories;

namespace HYPJ.Infrastructure.Respositories
{
    public class AccountRepository : BaseRepositoryHasPaging<Account, int>, IAccountRespository
    {
        public AccountRepository(StarCloudDbContext dbContext, IPropertyMappingContainer pmContainer) 
            : base(dbContext, pmContainer)
        {

        }
    }
}

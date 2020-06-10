using HYPJ.Core.Paging;
using HYPJ.Core.Paging.PropertyMapping;
using HYPJ.Core.Paging.QueryParameters;
using HYPJ.Core.SeedWorks;
using HYPJ.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace HYPJ.Infrastructure.Respositories
{
    public abstract class BaseRepositoryHasPaging<TEntity, TPrimaryKey>
        : BaseRepository<TEntity, TPrimaryKey>, IRepositoryHasPaging<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        private readonly IPropertyMappingContainer _pmContainer;

        protected BaseRepositoryHasPaging(
            StarCloudDbContext dbContext,
            IPropertyMappingContainer pmContainer) : base(dbContext)
        {
            _pmContainer = pmContainer;
        }

        public virtual async Task<PaginatedList<TEntity>> GetListByPagingParameterAsync<TResource>(
            PagingParam parameter)
            where TResource : class
        {
            var query = Table.AsQueryable();
            var filter = parameter.BuildFilterCondition();
            if (filter != null)
                query = query.Where(filter.Item1, filter.Item2);

            query = query.ApplySort(parameter.OrderBy, _pmContainer.Resolve<TResource, TEntity, TPrimaryKey>());

            var count = await query.CountAsync();

            var data = await query
                .Skip(parameter.PageIndex)
                .Take(parameter.PageSize)
                .ToListAsync();

            return new PaginatedList<TEntity>(parameter.PageIndex, parameter.PageSize, count, data);
        }
    }

}
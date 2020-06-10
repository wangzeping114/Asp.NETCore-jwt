using HYPJ.Core.Paging;
using HYPJ.Core.Paging.QueryParameters;
using System.Threading.Tasks;

namespace HYPJ.Core.SeedWorks
{
    public interface IRepositoryHasPaging<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>
     where TEntity : class, IEntity<TPrimaryKey>
    {
        /// <summary>
        /// 根据分页参数获取数据列表
        /// </summary>        
        /// <typeparam name="TResource"></typeparam>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Task<PaginatedList<TEntity>> GetListByPagingParameterAsync<TResource>(PagingParam parameter)
            where TResource : class;
    }
}

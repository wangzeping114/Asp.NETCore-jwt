using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HYPJ.Core.SeedWorks
{
    public interface IRepository<TEntity, TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey>
    {
        /// <summary>
        /// 工作单元
        /// </summary>
        IUnitOfWork UnitOfWork { get; }

        /// <summary>
        /// 表数据
        /// </summary>
        IQueryable<TEntity> Entities { get; }

        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <returns></returns>
        Task<IQueryable<TEntity>> GetAllAsync();

        /// <summary>
        /// 获取所有数据列表(不跟踪数据)
        /// </summary>
        /// <returns></returns>
        Task<List<TEntity>> GetAllListAsNoTrackingAsync();

        /// <summary>
        /// 获取所有数据并可包含导航属性
        /// </summary>
        /// <param name="propertySelectors"></param>
        /// <returns></returns>
        Task<IQueryable<TEntity>> GetAllIncludingAsync(params Expression<Func<TEntity, object>>[] propertySelectors);

        /// <summary>
        /// 获取所有数据列表
        /// </summary>
        /// <returns></returns>
        Task<List<TEntity>> GetAllListAsync();

        /// <summary>
        /// 根据查询条件获取数据列表(不跟踪数据)
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<List<TEntity>> GetAllListAsNoTrackingAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 根据查询条件获取数据列表
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<List<TEntity>> GetAllListAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 根据主键获取数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> GetAsync(TPrimaryKey id);

        /// <summary>
        /// 根据条件获取唯一数据
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 根据条件获取首条数据
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 插入新数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TEntity> InsertAsync(TEntity entity);

        /// <summary>
        /// 批量插入数据
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task InsertEntitiesAsync(IEnumerable<TEntity> entities);

        /// <summary>
        /// 插入新数据并返回主键
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TPrimaryKey> InsertAndGetIdAsync(TEntity entity);

        /// <summary>
        /// 插入或更新数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TEntity> InsertOrUpdateAsync(TEntity entity);

        /// <summary>
        /// 插入或更新数据并返回主键
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TPrimaryKey> InsertOrUpdateAndGetId(TEntity entity);

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TEntity> UpdateAsync(TEntity entity);

        /// <summary>
        /// 更新数据列表
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="properties"></param>
        /// <returns></returns>
        Task<TEntity> UpdateAsync(TEntity entity, params Expression<Func<TEntity, object>>[] properties);

        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task UpdateEntitiesAsync(IEnumerable<TEntity> entities);

        /// <summary>
        /// 根据主键更新数据
        /// </summary>
        /// <param name="id"></param>
        /// <param name="updateFunc"></param>
        /// <returns></returns>
        Task<TEntity> UpdateAsync(TPrimaryKey id, Func<TEntity, Task> updateFunc);

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task DeleteAsync(TEntity entity);

        /// <summary>
        /// 根据主键删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteAsync(TPrimaryKey id);

        /// <summary>
        /// 获取数据总量
        /// </summary>
        /// <returns></returns>
        Task<int> CountAsync();

        /// <summary>
        /// 根据条件获取数据总量
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 获取数据总量
        /// </summary>
        /// <returns></returns>
        Task<long> LongCountAsync();

        /// <summary>
        /// 根据条件获取数据总量
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<long> LongCountAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<int> ExecuteSqlCommandAsync(string sql, params object[] parameters);
    }
}

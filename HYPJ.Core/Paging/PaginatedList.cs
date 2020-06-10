using System.Collections.Generic;

namespace HYPJ.Core.Paging
{
    /// <inheritdoc />
    /// <summary>
    /// 分页数据
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PaginatedList<T> : List<T> where T : class
    {
        public int code { get; }
        /// <summary>
        /// 页大小
        /// </summary>
        public int PageSize { get; }
        /// <summary>
        /// 页索引
        /// </summary>
        public int PageIndex { get; }

        /// <summary>
        /// 总数据量
        /// </summary>
        public int TotalItemsCount { get; }
        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount => TotalItemsCount / PageSize + (TotalItemsCount % PageSize > 0 ? 1 : 0);

        /// <summary>
        /// 是否有上一页
        /// </summary>
        public bool HasPrevious => PageIndex > 0;
        /// <summary>
        /// 是否有下一页
        /// </summary>
        public bool HasNext => PageIndex < PageCount - 1;

        /// <inheritdoc />
        /// <summary>
        /// 分页数据
        /// </summary>
        /// <param name="pageIndex">页索引</param>
        /// <param name="pageSize">页大小</param>
        /// <param name="totalItemsCount">数据总量</param>
        /// <param name="data">数据列表</param>
        public PaginatedList(int pageIndex, int pageSize, int totalItemsCount, IEnumerable<T> data)
        {
            PageIndex = pageIndex >= 0 ? pageIndex : 0;
            PageSize = pageSize >= 0 ? pageSize : 0;
            TotalItemsCount = totalItemsCount >= 0 ? totalItemsCount : 0;
            AddRange(data);
        }
    }
}

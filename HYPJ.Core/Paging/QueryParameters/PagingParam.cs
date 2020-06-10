using System;

namespace HYPJ.Core.Paging.QueryParameters
{
    public class PagingParam
    {
        /// <summary>
        /// 默认的页大小
        /// </summary>
        private const int DEFAULT_PAGE_SIZE = 10;

        /// <summary>
        /// 默认最大的页大小
        /// </summary>
        private const int DEFAULT_MAX_PAGE_SIZE = 100;

        private int _pageIndex;
        private int _pageSize = DEFAULT_PAGE_SIZE;
        private int _maxPageSize = DEFAULT_MAX_PAGE_SIZE;
        private string _orderBy = "Id desc";


        protected virtual int MaxPageSize
        {

            get => _maxPageSize;
            set
            {
                if (value < 1 || DEFAULT_MAX_PAGE_SIZE < value)
                    _maxPageSize = DEFAULT_PAGE_SIZE;
                else
                    _maxPageSize = value;
            }
        }

        /// <summary>
        /// 页索引
        /// </summary>
        public int PageIndex
        {
            get => _pageIndex;
            set => _pageIndex = value < 0 ? 0 : value;
        }

        /// <summary>
        /// 页大小
        /// </summary>
        public int PageSize
        {
            get => _pageSize;
            set
            {
                if (value < 1)
                    _pageSize = DEFAULT_PAGE_SIZE;
                else if (value > MaxPageSize)
                    _pageSize = MaxPageSize;
                else
                    _pageSize = value;
            }
        }
        /// <summary>
        /// 排序字段
        /// </summary>
        public string OrderBy
        {
            get => _orderBy;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _orderBy = value;
            }
        }

        /// <summary>
        /// 查询字段
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 构建过滤条件
        /// </summary>
        /// <returns></returns>
        public virtual Tuple<string, Object[]> BuildFilterCondition()
        {
            var filterParam = PagingHelper.GeneratePredicateAndArgsByParam(this);
            if (filterParam == null)
                return null;

            return new Tuple<string, object[]>(filterParam.Item1, filterParam.Item2.ToArray());
        }

    }
}

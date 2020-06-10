using HYPJ.Core.Entites;
using HYPJ.Core.Enums;
using HYPJ.Core.Paging;
using HYPJ.Core.Paging.Attributes;
using HYPJ.Core.Paging.QueryParameters;
using System;

namespace HYPJ.Applicatoin.QueryParameters
{
    public class SysOperatorPagingParam:PagingParam
    {
        /// <summary>
        /// 大于等于
        /// </summary>
        [FilterField(nameof(Account.CreatedOn), FilterOperator.Ge)]
         public DateTime CreateOn { get; set; }
        /// <summary>
        /// 小于
        /// </summary>
        [FilterField(nameof(Account.CreatedOn), FilterOperator.Lt)]
        public DateTime CreateEnd { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [FilterField(nameof(Account.FullName), FilterOperator.Eq)]
        public string FullName { get; set; }

        
        
    }
}

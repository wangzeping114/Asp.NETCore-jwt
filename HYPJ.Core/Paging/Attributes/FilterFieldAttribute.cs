using HYPJ.Core.Enums;
using System;

namespace HYPJ.Core.Paging.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class FilterFieldAttribute : Attribute
    {
        /// <summary>
        /// 过滤字段
        /// </summary>
        /// <param name="propertyName">对应属性名</param>
        /// <param name="operator">操作符</param>
        public FilterFieldAttribute(
            string propertyName = null,
            FilterOperator @operator = FilterOperator.Eq)
        {
            Operator = @operator;
            PropertyName = propertyName;
        }

        public string PropertyName { get; }

        public FilterOperator Operator { get; }
    }
}

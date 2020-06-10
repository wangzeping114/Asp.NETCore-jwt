using HYPJ.Core.Enums;
using HYPJ.Core.Paging.Attributes;
using HYPJ.Core.Paging.QueryParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HYPJ.Core.Paging
{
    public class PagingHelper
    {
        private static string ConvertOperator(FilterOperator op)
        {
            switch (op)
            {
                case FilterOperator.Eq:
                    return "==";
                case FilterOperator.Lt:
                    return "<";
                case FilterOperator.Le:
                    return "<=";
                case FilterOperator.Gt:
                    return ">";
                case FilterOperator.Ge:
                    return ">=";
                case FilterOperator.Ne:
                    return "!=";
                default:
                    throw new ArgumentOutOfRangeException(nameof(op), op, null);
            }
        }
        /// <summary>
        /// 生成筛选条件和参数
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static Tuple<string, List<object>> GeneratePredicateAndArgsByParam(PagingParam param)
        {
            var properies = param.GetType().GetProperties();
            var keyValuePairs = new List<KeyValuePair<string, KeyValuePair<object, FilterOperator>>>();
            foreach (var propertyinfo in properies)
            {
                var filterAttr = propertyinfo.GetCustomAttribute<FilterFieldAttribute>();
                if (filterAttr == null)
                    continue;

                var name = filterAttr.PropertyName ?? propertyinfo.Name;
                var op = filterAttr.Operator;
                var value = propertyinfo.GetValue(param);
                if (value == null)
                    continue;

                var ptype = propertyinfo.PropertyType;
                if (!ptype.IsClass)
                {
                    if (ptype == typeof(short))
                    {
                        if ((short)value == default(short))
                            continue;
                    }
                    else if (ptype == typeof(int))
                    {
                        if ((int)value == default(int))
                            continue;
                    }
                    else if (ptype == typeof(long))
                    {
                        if ((long)value == default(long))
                            continue;
                    }
                    else if (ptype == typeof(float))
                    {
                        if ((float)value == default(float))
                            continue;
                    }
                    else if (ptype == typeof(double))
                    {
                        if ((double)value == default(double))
                            continue;
                    }
                    else if (ptype == typeof(decimal))
                    {
                        if ((decimal)value == default(decimal))
                            continue;
                    }
                    else if (ptype == typeof(DateTime))
                    {
                        if ((DateTime)value == default(DateTime))
                            continue;
                    }
                }
                keyValuePairs.Add(new KeyValuePair<string, KeyValuePair<object, FilterOperator>>(name, new KeyValuePair<object, FilterOperator>(value, op)));
            }

            if (!keyValuePairs.Any())
                return null;

            var predicate = string.Empty;
            var args = new List<object>();
            var index = 0;
            foreach (var item in keyValuePairs)
            {
                predicate += $"{item.Key} {ConvertOperator(item.Value.Value)} @{index} and ";
                args.Add(item.Value.Key);
                index++;
            }
            predicate = predicate.TrimEnd(" and ".ToCharArray());

            return new Tuple<string, List<object>>(predicate, args);
        }
        /// <summary>
        /// 获取属性名称
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static string GetPropertyNameByAttribute(PropertyInfo property)
        {
            var attr = property?.GetCustomAttribute<PropertyNameAttribute>();
            if (attr == null)
                return string.Empty;

            return attr.PropertyName ?? property.Name;
        }
    }
}

using HYPJ.Core.Paging.PropertyMapping;
using System;
using System.Linq;
using System.Linq.Dynamic.Core;
namespace HYPJ.Infrastructure.Extensions
{
    public static class QueryableExtensions
    {
        /// <summary>
        /// 动态排序
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="source"></param>
        /// <param name="orderBy"></param>
        /// <param name="propertyMapping"></param>
        /// <returns></returns>
        public static IQueryable<TEntity> ApplySort<TEntity>(this IQueryable<TEntity> source, string orderBy,
            IPropertyMapping propertyMapping)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (propertyMapping == null)
                throw new ArgumentNullException(nameof(propertyMapping));

            var mappingDectionary = propertyMapping.MappingDictionary;
            if (mappingDectionary == null)
                throw new ArgumentNullException(nameof(mappingDectionary));

            if (string.IsNullOrWhiteSpace(orderBy))
                return source;

            var orderbyAfterSplit = orderBy.Split(',');
            foreach (var orderByClause in orderbyAfterSplit)
            {
                var trimmedOrderByClause = orderByClause.Trim();
                var orderDescending = trimmedOrderByClause.EndsWith(" desc");
                var mappedProperties = propertyMapping.GetMappedPropertiesByKey(trimmedOrderByClause);

                if (mappedProperties == null)
                    continue;

                foreach (var destinationProperty in mappedProperties)
                {
                    if (destinationProperty.Revert)
                        orderDescending = !orderDescending;
                    source = source.OrderBy(
                        $"{destinationProperty.Name} {(orderDescending ? "descending" : "ascending")}");
                }
            }

            return source;
        }
    }
}

using HYPJ.Core.SeedWorks;
using System;
using System.Collections.Generic;
namespace HYPJ.Core.Paging.PropertyMapping
{
    public class PropertyMapping<TSource, TDestination, TPrimanyKey>
         : IPropertyMapping where TDestination : IEntity<TPrimanyKey>
    {
        public Dictionary<string, List<MappedProperty>> MappingDictionary { get; }


        public List<MappedProperty> GetMappedPropertiesByKey(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                return null;

            string trimKey = key.Trim();
            var indexOfFirstSpace = trimKey.IndexOf(" ", StringComparison.Ordinal);
            var propertyName = indexOfFirstSpace == -1 ? trimKey : trimKey.Remove(indexOfFirstSpace);

            //true为包含指定键的元素
            if (!MappingDictionary.TryGetValue(propertyName, out var mappedProperties))
                throw new ArgumentException($"缺少{propertyName}键映射");

            // 颠倒元素顺序
            mappedProperties.Reverse();

            return mappedProperties;
        }

        public PropertyMapping(Dictionary<string, List<MappedProperty>> mappingDictiongary)
        {
            MappingDictionary = mappingDictiongary;
            if (!mappingDictiongary.ContainsKey(nameof(IEntity<TPrimanyKey>.Id)))
                MappingDictionary[nameof(IEntity<TPrimanyKey>.Id)] = new List<MappedProperty>()
                {
                    new MappedProperty(nameof(IEntity<TPrimanyKey>.Id))
                };
        }

    }
}

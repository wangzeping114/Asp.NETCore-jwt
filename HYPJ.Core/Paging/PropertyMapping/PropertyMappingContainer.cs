using HYPJ.Core.Paging.Attributes;
using HYPJ.Core.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HYPJ.Core.Paging.PropertyMapping
{
    public class PropertyMappingContainer : IPropertyMappingContainer
    {
        private readonly Dictionary<Type, IPropertyMapping> propertyMappings = new Dictionary<Type, IPropertyMapping>();

        public void Register<TResource, TDestination, TPrimanyKey>()
            where TDestination : IEntity<TPrimanyKey>
        {
            var resourceType = typeof(TResource);
            var properties = resourceType.GetProperties();
            var mappingDictionary =
                new Dictionary<string, List<MappedProperty>>(StringComparer.CurrentCultureIgnoreCase);
            foreach (var propertyInfo in properties)
            {
                var mapAttr = propertyInfo
                    .GetCustomAttributes<PropertyMappingAttribute>()
                    .ToArray();

                if (!mapAttr.Any())
                    continue;

                var mappings = mapAttr.Select(attr => attr.MappedProperty ?? new MappedProperty(propertyInfo.Name))
                    .ToList();

                mappingDictionary.Add(propertyInfo.Name, mappings);
            }

            if (!mappingDictionary.Any())
                throw new Exception($"类型{resourceType.Name}属性没有附加{nameof(PropertyMappingAttribute)}无法注册!");

            var propertyMap = new PropertyMapping<TResource, TDestination, TPrimanyKey>(mappingDictionary);

            propertyMappings[resourceType] = propertyMap;

        }

        public IPropertyMapping Resolve<TResource, TDestination, TPrimanyKey>()
            where TDestination : IEntity<TPrimanyKey>
        {
            if (!propertyMappings.TryGetValue(typeof(TResource), out var matchingMapping))
                throw new Exception($"没有找到属性映射实例<{nameof(TResource)},{nameof(TDestination)}>");

            return matchingMapping;
        }

        public bool ValidateMappingExistsFor<TResource, TDestination, TPrimanyKey>(string fields)
            where TResource : class
            where TDestination : IEntity<TPrimanyKey>
        {
            if (string.IsNullOrWhiteSpace(fields))
                return true;

            var propertyMapping = Resolve<TResource, TDestination, TPrimanyKey>();
            var fieldAfterSplit = fields.Split(',');
            foreach (var field in fieldAfterSplit)
            {
                try
                {
                    var mappedProperties = propertyMapping.GetMappedPropertiesByKey(field);
                    if (mappedProperties == null)
                        return false;
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }
    }
}

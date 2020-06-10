using System.Collections.Generic;
namespace HYPJ.Core.Paging.PropertyMapping
{
    public interface IPropertyMapping
    {
        /// <summary>
        /// 映射字典
        /// </summary>
        Dictionary<string, List<MappedProperty>> MappingDictionary { get; }

        /// <summary>
        /// 根据key值获取映射属性
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        List<MappedProperty> GetMappedPropertiesByKey(string key);
    }
}

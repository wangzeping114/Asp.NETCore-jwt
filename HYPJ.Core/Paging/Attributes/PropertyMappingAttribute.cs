using HYPJ.Core.Paging.PropertyMapping;
using System;

namespace HYPJ.Core.Paging.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class PropertyMappingAttribute : Attribute
    {
        /// <summary>
        /// 映射资源和实体属性对应字段
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="revert"></param>
        public PropertyMappingAttribute(string propertyName = null, bool revert = false)
        {
            if (string.IsNullOrWhiteSpace(propertyName))
                return;

            MappedProperty = new MappedProperty(propertyName, revert);
        }

        public MappedProperty MappedProperty { get; }
    }
}

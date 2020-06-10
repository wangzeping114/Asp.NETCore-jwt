using System;

namespace HYPJ.Core.Paging.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PropertyNameAttribute : Attribute
    {
        public PropertyNameAttribute(string name)
        {
            PropertyName = name;
        }

        /// <summary>
        ///属性名
        /// </summary>
        public string PropertyName { get; }
    }
}

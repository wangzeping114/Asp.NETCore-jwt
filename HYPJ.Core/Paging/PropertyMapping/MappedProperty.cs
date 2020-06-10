namespace HYPJ.Core.Paging.PropertyMapping
{
    public class MappedProperty
    {
        public MappedProperty(string name, bool revert = false)
        {
            Name = name;
            Revert = revert;
        }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 是否反转
        /// </summary>
        public bool Revert { get; set; }
    }
}

using HYPJ.Core.SeedWorks;
using System.Collections.Generic;

namespace HYPJ.Core.Entites
{
    /// <summary>
    /// 栏目、类别
    /// </summary>
    public class Category : Entity<int>
    {
        public Category()
        {
            Commoditys = new HashSet<Commodity>();
        }
        /// <summary>
        /// Key
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 栏目名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        public virtual ICollection<Commodity> Commoditys { get; set; }
    }
}


using HYPJ.Core.Paging.Attributes;
using System.Collections.Generic;

namespace HYPJ.Applicatoin.Resources
{
    public class MenuResource
    {
        [PropertyMapping]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [PropertyMapping]
        public int? ParentId { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        [PropertyMapping]
        public string Icon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [PropertyMapping]
        public string Name { get; set; }

        /// <summary>
        /// 链接动作
        /// </summary>
        [PropertyMapping]
        public string ActionSref { get; set; }


        /// <summary>
        /// path路径
        /// </summary>
        [PropertyMapping]
        public string Path { get; set; }

        /// <summary>
        /// 子类
        /// </summary>
        [PropertyMapping]
        public  List<MenuResource> Children { get; set; }
    }
}

namespace HYPJ.Applicatoin.Dots
{
    public class MenuInput
    {
        public MenuInput()
        {
            ParentId = -1;
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 链接动作
        /// </summary>
        public string ActionSref { get; set; }

        /// <summary>
        /// path路径
        /// </summary>
        public string Path { get; set; }

    }
}

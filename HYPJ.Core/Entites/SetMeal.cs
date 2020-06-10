using HYPJ.Core.SeedWorks;

namespace HYPJ.Core.Entites
{
    /// <summary>
    /// 套餐
    /// </summary>
    public class SetMeal : Entity<int>
    {
        /// <summary>
        /// 套餐标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 套餐描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 活动价
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 市场价
        /// </summary>
        public decimal MarketPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual SetMealStock SetMealStock { get; set; }


    }
}

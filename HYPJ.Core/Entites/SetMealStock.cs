using HYPJ.Core.SeedWorks;

namespace HYPJ.Core.Entites
{
    /// <summary>
    /// 套餐库存
    /// </summary>
    public class SetMealStock : Entity<int>
    {
        /// <summary>
        /// 数量
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 预留数
        /// </summary>
        public int ReservedQuantity { get; set; }
        /// <summary>
        /// 已销售数量
        /// </summary>
        public int HaveSalesQuantity { get; set; }
        /// <summary>
        /// 套餐ID
        /// </summary>
        public int SetMealId { get; set; }

        ///<summary>
        ///套餐
        /// </summary>
        public virtual SetMeal SetMeal { get; set; }
    }
}

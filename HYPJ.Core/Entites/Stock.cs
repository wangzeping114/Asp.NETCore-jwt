using HYPJ.Core.SeedWorks;

namespace HYPJ.Core.Entites
{
    /// <summary>
    /// 库存
    /// </summary>
    public class Stock : Entity<int>
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
        /// 商品ID
        /// </summary>
        public int CommodityId { get; set; }

        ///<summary>
        ///商品
        /// </summary>
        public virtual Commodity Commodity { get; set; }
    }
}

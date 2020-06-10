using HYPJ.Core.SeedWorks;

namespace HYPJ.Core.Entites
{
    /// <summary>
    /// 商户地址
    /// </summary>
    public class StoreAddress : Entity<int>
    {
        /// <summary>
        /// 商户
        /// </summary>
        public virtual Store Store { get; set; }

        /// <summary>
        /// 地址ID
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public virtual Address Address { get; set; }
    }
}

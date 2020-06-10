namespace HYPJ.Core.SeedWorks
{
    public interface ISoftDeleteBaseEntity
    {
        /// <summary>
        /// 软删除
        /// </summary>
        bool IsDeleted { get; set; }
    }
}

namespace HYPJ.Core.SeedWorks
{
    public interface IEntity<TPrimaryKey>
    {
        /// <summary>
        /// 主键
        /// </summary>
        TPrimaryKey Id { get; set; }

        /// <summary>
        /// 检查该实体为瞬态(未持久化)
        /// </summary>
        /// <returns></returns>
        bool IsTransient();
    }
}

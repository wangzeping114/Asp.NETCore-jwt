using HYPJ.Core.SeedWorks;
namespace HYPJ.Core.Paging.PropertyMapping
{
    public interface IPropertyMappingContainer
    {
        /// <summary>
        /// 注册
        /// </summary>
        /// <typeparam name="TResource"></typeparam>
        /// <typeparam name="TDestination"></typeparam>
        /// <typeparam name="TPrimanyKey"></typeparam>
        void Register<TResource, TDestination, TPrimanyKey>()
            where TDestination : IEntity<TPrimanyKey>;

        /// <summary>
        /// 获取
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TDestination"></typeparam>
        /// <typeparam name="TPrimanyKey"></typeparam>
        /// <returns></returns>
        IPropertyMapping Resolve<TSource, TDestination, TPrimanyKey>()
            where TDestination : IEntity<TPrimanyKey>;

        /// <summary>
        /// 验证
        /// </summary>
        /// <typeparam name="TResource"></typeparam>
        /// <typeparam name="TDestination"></typeparam>
        /// <typeparam name="TPrimanyKey"></typeparam>
        /// <param name="fields"></param>
        /// <returns></returns>
        bool ValidateMappingExistsFor<TResource, TDestination, TPrimanyKey>(string fields)
            where TResource : class
            where TDestination : IEntity<TPrimanyKey>;
    }
}

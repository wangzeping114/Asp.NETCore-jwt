using AutoMapper;
using HYPJ.Applicatoin.Exceptions;
using HYPJ.Core.Paging;
using HYPJ.Core.Paging.PropertyMapping;
using HYPJ.Core.Paging.QueryParameters;
using HYPJ.Core.SeedWorks;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HYPJ.Applicatoin.Services
{
    public abstract class BaseService
    {
        private readonly IMapper _mapper;

        private readonly IPropertyMappingContainer _pmContainer;

        protected BaseService(IPropertyMappingContainer propertyMappingContainer, IMapper mapper)
        {
            _mapper = mapper;
            _pmContainer = propertyMappingContainer;

        }

        protected TDestination MapTo<TDestination>(object source)
        {
            return _mapper.Map<TDestination>(source);
        }
        protected TDestination Map<TSource, TDestination>(TSource source)
        {
            return _mapper.Map<TSource, TDestination>(source);
        }

        protected void Map(object source, object destination)
        {
            _mapper.Map(source, destination);
        }
        protected async Task<PaginatedList<TResource>> GetListByPagingParamAsync<TResource, TEntity, TPrimaryKey>
            (IRepositoryHasPaging<TEntity, TPrimaryKey> repository, PagingParam param)
            where TResource : class
            where TEntity : class, IEntity<TPrimaryKey>
        {
            if (!_pmContainer.ValidateMappingExistsFor<TResource, TEntity, TPrimaryKey>(param.OrderBy))
                throw new FriendlyException("无法找到用于排序的字段!");

            var data = await repository
                .GetListByPagingParameterAsync<TResource>(param);

            var resoures = _mapper.Map<IEnumerable<TResource>>(data);
            return new PaginatedList<TResource>(
                data.PageIndex, data.PageSize, data.TotalItemsCount, resoures);
        }
    }
}

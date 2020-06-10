using AutoMapper;
using HYPJ.Core.Paging.PropertyMapping;

namespace HYPJ.Applicatoin.Services
{
    public class ProductServcie : BaseService
    {
        public ProductServcie(IPropertyMappingContainer propertyMappingContainer, IMapper mapper) : base(propertyMappingContainer, mapper)
        {
        }
    }
}


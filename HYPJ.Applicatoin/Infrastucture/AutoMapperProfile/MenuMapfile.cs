using AutoMapper;
using HYPJ.Applicatoin.Dots;
using HYPJ.Applicatoin.Resources;
using HYPJ.Core.Entites;

namespace HYPJ.Applicatoin.Infrastucture.AutoMapperProfile
{
    public class MenuMapfile: Profile
    {
        public MenuMapfile()
        {
            CreateMap<MenuInput, Menu>()
               .ForMember(s => s.Name, o => o.MapFrom(s => s.Name))
               .ForMember(s => s.Icon, o => o.MapFrom(s => s.Icon))
               .ForMember(s => s.ActionSref, o => o.MapFrom(s => s.ActionSref))
               .ForMember(s => s.ParentId, o => o.Condition(s => s.ParentId > -1));
 
            CreateMap<Menu, MenuResource>().ReverseMap();
        }
    }
}

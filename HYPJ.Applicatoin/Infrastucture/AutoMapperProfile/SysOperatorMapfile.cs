using AutoMapper;
using HYPJ.Applicatoin.Dots;
using HYPJ.Applicatoin.Resources;
using HYPJ.Core.Entites;

namespace HYPJ.Applicatoin.Infrastucture.AutoMapperProfile
{
    public class SysOperatorMapfile:Profile
    {
        public SysOperatorMapfile()
        {
            CreateMap<SysOperatorResource,EditUserInput>()
                .ReverseMap();

            CreateMap<EditUserInput, Account>()
                .ReverseMap();

            CreateMap<Account, SysOperatorResource>()
                    .ForMember(d=>d.Id,o=>o.MapFrom(s=>s.Id))
                    .ForMember(d => d.UserName, o => o.MapFrom(s => s.UserName))
                    .ForMember(d => d.FullName, o => o.MapFrom(s => s.FullName))
                    .ForMember(d => d.Phone, o => o.MapFrom(s => s.Phone))
                    .ForMember(d => d.RoleId, o => o.MapFrom(s => s.RoleId))
                    .ForMember(d => d.RoleName, o => o.MapFrom(s => s.Role.Name))
                    .ForMember(d => d.Remark, o => o.MapFrom(s => s.Role.Description))
                    .ForMember(d => d.IsDisplay, o => o.MapFrom(s => s.IsDisplay))
                    .ForMember(d=>d.BirthOn,o=>o.MapFrom(s=>s.BirthOn))
                    .ForMember(d => d.CreateAt, o => o.MapFrom(s => s.CreatedOn));
        }

    }
}

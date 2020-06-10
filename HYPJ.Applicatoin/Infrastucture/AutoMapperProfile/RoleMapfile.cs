using AutoMapper;
using HYPJ.Applicatoin.Resources;
using HYPJ.Core.Entites;

namespace HYPJ.Applicatoin.Infrastucture.AutoMapperProfile
{
    public class RoleMapfile: Profile
    {
        public RoleMapfile()
        {
            CreateMap<Role, RoleResource>().ReverseMap();
        }
    }
}

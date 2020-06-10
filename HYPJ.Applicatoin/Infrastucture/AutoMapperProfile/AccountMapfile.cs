using AutoMapper;
using HYPJ.Applicatoin.Dots;
using HYPJ.Applicatoin.Resources;
using HYPJ.Core.Entites;

namespace HYPJ.Applicatoin.Infrastucture.AutoMapperProfile
{
    public class AccountMapfile : Profile
    {
        public AccountMapfile()
        {
            CreateMap<AddUserInput, Account>()
                .ReverseMap();
 
            CreateMap<Account, AccountResource>()
              .ForMember(d => d.UserName,
                  o => o.MapFrom(s => s.UserName))
              .ForMember(d => d.FullName,
                  o => o.MapFrom(s => s.FullName));
        }
    }
}

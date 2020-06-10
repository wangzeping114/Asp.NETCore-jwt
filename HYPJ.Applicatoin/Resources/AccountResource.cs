using HYPJ.Core.Paging.Attributes;

namespace HYPJ.Applicatoin.Resources
{
    public class AccountResource
    {
        [PropertyMapping]
        public int Id { get; set; }

        [PropertyMapping]
        public int RoleId { get; set; }

        [PropertyMapping]
        public string UserName { get; set; }

        [PropertyMapping]
        public string FullName { get; set; }


    }
}

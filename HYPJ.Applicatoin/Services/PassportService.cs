using AutoMapper;
using HYPJ.Applicatoin.Dots;
using HYPJ.Applicatoin.Exceptions;
using HYPJ.Applicatoin.Handler;
using HYPJ.Applicatoin.QueryParameters;
using HYPJ.Applicatoin.Resources;
using HYPJ.Core.Entites;
using HYPJ.Core.Paging;
using HYPJ.Core.Paging.PropertyMapping;
using HYPJ.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HYPJ.Applicatoin.Services
{
    public class PassportService : BaseService
    {
        private readonly IAccountRespository _accountRepository;
        private readonly IPasswordHandler _passwordHadler;
        private readonly IRoleRespository _roleRespository;
        private readonly IMenuRespository _menuRespository;

        public PassportService(IAccountRespository accountRespository,
            IPasswordHandler passwordHandler,

             IRoleRespository roleRespository,
             IMenuRespository menuRespository,
             IPropertyMappingContainer propertyMappingContainer, IMapper mapper)
             : base(propertyMappingContainer, mapper)
        {
            _accountRepository = accountRespository;
            _passwordHadler = passwordHandler;
            _roleRespository = roleRespository;
            _menuRespository = menuRespository;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userSiginInput"></param>
        /// <returns></returns>
        public async Task<AccountResource> SiginAsync(UserSiginInput userSiginInput)
        {
            var user = await _accountRepository.FirstOrDefaultAsync(p => p.UserName.Equals(userSiginInput.UserName.Trim()));
            if (user == null)
            {
                throw new FriendlyException("用户名或密码错误!", 404);
            }
            var verifyPwd = _passwordHadler.VerifyHashedPassword(user.Password, user.Salt, userSiginInput.PassWord);
            if (!verifyPwd)
            {
                throw new FriendlyException("用户名或密码错误!", 404);
            }
            return MapTo<AccountResource>(user);
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Newpwd"></param>
        /// <returns></returns>
        public async Task UpdateSysOperatorPassword(int id, string Newpwd)
        {
            var (salt, encrypwd) = _passwordHadler.GenerateEncryptPassword(Newpwd);
            object[] p = new object[] { encrypwd, salt, id };
            await _accountRepository.ExecuteSqlCommandAsync("update LYPJ.Account Set [Password]=@p0,Salt=@p1 where Id=@p2", p);
            await _accountRepository.UnitOfWork.SaveChangesAsync();
        }


        /// <summary>
        /// 更新管理员停用或启用状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public async Task UpdateSysOperatorStateAsync(int id, string state)
        {
            await _accountRepository.ExecuteSqlCommandAsync("Update LYPJ.Account set IsDisplay=@p0 where Id=@p1", new object[] { state, id });
            await _accountRepository.UnitOfWork.SaveChangesAsync();
        }


        /// <summary>
        /// 操作员管理列表
        /// </summary>
        /// <returns></returns>
        public async Task<List<SysOperatorResource>> GetSysOperatorList()
        {
            var users = await _accountRepository.GetAllAsync();

            return Map<List<Account>, List<SysOperatorResource>>(users.ToList());
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<PaginatedList<SysOperatorResource>> GetSysOperatorByPagingParamAsync(SysOperatorPagingParam param)
        {
            return await GetListByPagingParamAsync<SysOperatorResource, Account, int>(_accountRepository, param);
        }

        /// <summary>
        /// 根据ID查询管理员
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public async Task<SysOperatorResource> GetSysOperatorById(int userid)
        {
            var account = await _accountRepository.GetAsync(userid);
            return Map<Account, SysOperatorResource>(account);
        }

        /// <summary>
        /// 更新操作员列表
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task UpdateSysOperator(EditUserInput input)
        {
            var account = Map<EditUserInput, Account>(input);

            await _accountRepository
                .UpdateAsync(account, d => d.UserName, d => d.BirthOn, d => d.FullName,
                d => d.Avatar, d => d.IsDisplay, d => d.Phone, d => d.RoleId);

            await _accountRepository.UnitOfWork.SaveChangesAsync();
        }

        /// <summary>
        /// 新增管理员
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task AddSysOperatorAsync(AddUserInput input)
        {
            var account = await GetAccountByName(input.UserName);
            if (account != null)
            {
                throw new FriendlyException($"{input.UserName}账号已经存在!", 404);
            }
            var entity = Map<AddUserInput, Account>(input);
            var (salt, encryptpwd) = _passwordHadler.GenerateEncryptPassword(entity.Password);
            entity.Password = encryptpwd;
            entity.Salt = salt;
            await _accountRepository.InsertAsync(entity);
        }



        /// <summary>
        /// 删除操作管理员
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteSysOperatorAsync(int id)
        {
            await _accountRepository.DeleteAsync(id);
        }


        /// <summary>
        /// 新增菜单页面
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task AddMenuAysnc(MenuInput input)
        {
            if (input.ParentId == -1)
            {
                var entity = Map<MenuInput, Menu>(input);
                await _menuRespository.InsertAsync(entity);
            }
            else
            {
                var parentEntity = await _menuRespository.GetParentMenu(input.ParentId.Value);
                var entity = Map<MenuInput, Menu>(input);
                parentEntity.Children.Add(entity);
                await _menuRespository.UnitOfWork.SaveChangesAsync();
            }
        }


        public async Task<List<MenuResource>> GetMenusByAccountId(int userid)
        {
            var user = await _accountRepository.GetAsync(userid);
            if (user.Role.IsSuperAdmin)
            {
                var menus = await GetMenus();
                return menus;
            }
            else
            {
                var menus = await GetMenusByRoleId(user.RoleId);
                return menus;
            }
        }


        /// <summary>
        /// 所有角色
        /// </summary>
        /// <returns></returns>
        public async Task<List<RoleResource>> GetAllRoles()
        {
            var roles = await _roleRespository.GetAllAsync();
            return Map<List<Role>, List<RoleResource>>(roles.ToList());
        }

        /// <summary>
        ///获取根据用户名 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        private async Task<Account> GetAccountByName(string userName)
         => await _accountRepository.SingleOrDefaultAsync(p => p.UserName.Equals(userName.Trim(), StringComparison.InvariantCultureIgnoreCase));


        /// <summary>
        /// 获取所有菜单
        /// </summary>
        /// <returns></returns>
        private async Task<List<MenuResource>> GetMenus()
        {
            var pmenus = await _menuRespository.GetAllMenus();
            return Map<List<Menu>, List<MenuResource>>(pmenus);
        }

        private async Task<List<MenuResource>> GetMenusByRoleId(int roleid)
        {
            var menus = await _menuRespository.GetMenuByRole(roleid);

            return Map<List<Menu>, List<MenuResource>>(menus);
        }
    }
}

using HYPJ.Applicatoin.Dots;
using HYPJ.Applicatoin.QueryParameters;
using HYPJ.Applicatoin.Resources;
using HYPJ.Applicatoin.Services;
using HYPJ.Web.Core.WebApi;
using HypjCms.Web.Base;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
namespace HypjCms.Web.Controllers.Sys
{
    public class SysOperatorController : BaseController
    {
        private readonly PassportService passportService;
        private readonly IMapper  Mapper;

        public SysOperatorController(PassportService passportService,IMapper mapper)
        {
            this.passportService = passportService;
            Mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> List(SysOperatorPagingParam pagingParam)
        {
            var opertors = await passportService.GetSysOperatorByPagingParamAsync(pagingParam);
            return View(opertors);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewData["roleid"] = CurrUser.RoleId.ToString();
            return View();
        }

        [HttpPost]
        public async Task<ApiResult> Add(AddUserInput input)
        {
            await passportService.AddSysOperatorAsync(input);
            return ApiResult.Success;
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int StaffId)
        {
            var sysOperator = await passportService.GetSysOperatorById(StaffId);
            ViewData["roleid"] = sysOperator.RoleId;
            var editUser= Mapper.Map<EditUserInput>(sysOperator);
            return View(editUser);
        }

        [HttpPost]
        public async Task<ApiResult> Edit(EditUserInput input)
        {
            await passportService.UpdateSysOperator(input);
            return ApiResult.Success;
        }

        [HttpGet]
        public async Task<IActionResult> UpdatePassword(int staffid)
        {
            var sysOperator = await passportService.GetSysOperatorById(staffid);
            return View(sysOperator);
        }

        [HttpPost]
        public async Task<ApiResult> UpdatePassword()
        {
            if (HttpContext.Request.Form.TryGetValue("NewPassword", out var queryNewPwd)
                 && HttpContext.Request.Form.TryGetValue("ConfirmPassword", out var queryCfmPwd)
                 && HttpContext.Request.Query.TryGetValue("StaffId", out var Id))
            {
                if (!queryNewPwd.Equals(queryCfmPwd))
                {
                    return ApiResult.GetRequestError($"{queryCfmPwd}前后密码不一致!");
                }
                else
                {
                    await passportService.UpdateSysOperatorPassword(int.Parse(Id), queryNewPwd);
                    return ApiResult.Success;
                }
            }
            else
            {
                return ApiResult.NotFound;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Search(SysOperatorPagingParam pagingParam)
        {
            var result= await List(pagingParam);
            return Json(result);
        }
        [HttpGet]
        public async Task<ApiResult> GetRoleList()
        {
            var roles = await passportService.GetAllRoles();
           
            return new ApiResult<List<RoleResource>>(roles);
        }
     

        [HttpPost]
        public async Task<ApiResult> Delete(int staffid)
        {
            await passportService.DeleteSysOperatorAsync(staffid);
            return ApiResult.Success;
        }


        [HttpPost]
        public async Task<ApiResult> UpdateState()
        {
            HttpContext.Request.Form.TryGetValue("staffid", out var id1);
            Console.WriteLine($"Id:{id1}");
            if (HttpContext.Request.Form.TryGetValue("staffid", out var id)
                && HttpContext.Request.Form.TryGetValue("state", out var state))
            {
                await passportService.UpdateSysOperatorStateAsync(int.Parse(id), state);
                return ApiResult.Success;
            }
            return ApiResult.GetRequestError("参数错误!");
        }

        //[HttpPost]
        //public async Task<ApiResult> DeleteBatch(List<int> idlist)
        //{
        //    throw new Exception();
        //}
     }
}
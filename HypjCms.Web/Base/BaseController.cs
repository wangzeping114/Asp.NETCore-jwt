using HYPJ.Applicatoin.Resources;
using HYPJ.Utilities.Extension;
using HYPJ.Utilities.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace HypjCms.Web.Base
{
    public class BaseController : Controller
    {
        public BaseController()
        {

        }
        protected string SessionUser => BaseSystemConfig.SessionUser;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string currUser=  WebHelper.GetSession(SessionUser);
            var controllerName= filterContext.RouteData.Values["controller"];
            var actionName = filterContext.RouteData.Values["action"];
            if (string.IsNullOrEmpty(currUser)&& !actionName.ToString().Equals("login", StringComparison.OrdinalIgnoreCase))
            {
                filterContext.Result = new RedirectResult("/Admin/Login");
            }
            base.OnActionExecuting(filterContext);
        }

        protected AccountResource CurrUser
        {
            get
            {
                string sessionJson = WebHelper.GetSession(SessionUser);
                var currUser= sessionJson.ToObject<AccountResource>();
                return currUser;
            }
        }
    }
}
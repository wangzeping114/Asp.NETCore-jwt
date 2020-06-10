using HYPJ.Web.Core.WebApi;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
namespace HYPJ.Web.Core.Filter
{
    public class ModelStateValidFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var apiResult = new ApiResult();
                foreach (var item in context.ModelState.Values)
                {
                    if (item.Errors.Count > 0)
                    {
                        apiResult = ApiResult.GetModelStateError(item.Errors[0].ErrorMessage);
                        break;
                    }
                }
                context.Result = new OkObjectResult(apiResult);
            }
        }
    }
}

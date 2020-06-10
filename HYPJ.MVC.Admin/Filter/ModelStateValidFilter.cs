using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;

namespace HYPJ.MVC.Admin.Filter
{
    public class ModelStateValidFilter : IActionFilter
    {


        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var controller = context.Controller as Controller;
                var model = context.ActionArguments?.Count > 0
                   ? context.ActionArguments.First().Value
                   : null;

                context.Result = (IActionResult)controller?.View(model)
                   ?? new BadRequestResult();
            }
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }
}

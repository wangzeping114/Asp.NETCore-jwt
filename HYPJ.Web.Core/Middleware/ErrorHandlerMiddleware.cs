using HYPJ.Applicatoin.Exceptions;
using HYPJ.Utilities.Helper;
using HYPJ.Web.Core.WebApi;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace HYPJ.Web.Core.Middleware
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        //private readonly IExceptionLogService _exceptionLogService;

        /// <summary>
        /// Initializes a new instance of the <see cref="HYPJ.Web.Core.Middleware.ErrorHandlerMiddleware"/> class.
        /// </summary>
        /// <param name="next">Next.</param>
        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        /// <summary>
        /// Invoke the specified context.
        /// </summary>
        /// <returns>The invoke.</returns>
        /// <param name="context">Context.</param>
        public async Task Invoke(Microsoft.AspNetCore.Http.HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                await HandleErrorAsync(context, exception);
            }
        }

        private async Task HandleErrorAsync(Microsoft.AspNetCore.Http.HttpContext context, Exception exception)
        {

            //await _exceptionLogService.AddExceptionAsync(new ExceptionLogModel()
            //{
            //    ClassName = nameof(exception),
            //    Message = exception.Message,
            //    Source = exception.Source,
            //    StackTrace = exception.StackTrace
            //        .Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList()
            //});
            //Console.WriteLine(exception.Message);
            //if (Debugger.IsAttached)
            //{
            //    Debugger.Break();
            //}
            Console.WriteLine($"ErrorHandler:{exception.Message}");
            ApiResult apiResult;
            if (exception is PermissionAuthorizeFailException)
            {
                apiResult = ApiResult.GetRequestError("权限验证失败");
            }
            else
            {
                apiResult = ApiResult.GetServerError(exception.Message);
            }
            var response = context.Response;
            response.ContentType = "application/json";
            await response.WriteAsync(JsonSerializerHelper.SerializeObject(apiResult));
        }
    }

    /// <summary>
    /// Error middleware extensions.
    /// </summary>
    public static class ErrorMiddlewareExtensions
    {
        /// <summary>
        /// Uses the error handler.
        /// </summary>
        /// <returns>The error handler.</returns>
        /// <param name="builder">Builder.</param>
        public static IApplicationBuilder UseErrorHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }

}

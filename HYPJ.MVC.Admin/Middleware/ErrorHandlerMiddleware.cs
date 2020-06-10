using HYPJ.Utilities;
using HYPJ.Utilities.Helper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Threading.Tasks;

namespace HYPJ.MVC.Admin.Middleware
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {

                await HandleErrorAsync(context, ex);
            }
        }
        private async Task HandleErrorAsync(HttpContext context, Exception exception)
        {

            Console.WriteLine(exception.Message);
            var model = new ModelError(exception, exception.Message);
            var response = context.Response;
            response.ContentType = "application/json";
            await response.WriteAsync(JsonSerializerHelper.SerializeObject(model));
        }
    }
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

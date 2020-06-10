using System;

namespace HYPJ.Web.Core.WebApi
{
    public class ApiResult
    {
        public int StatusCode { get; set; } = 0;

        public string StatusMessage { get; set; } = "success";

        public ApiResult() { }

        public ApiResult(int code, string msg) : this()
        {
            StatusCode = code;
            StatusMessage = msg;
        }

        public static ApiResult Success { get; } = new Lazy<ApiResult>(() => new ApiResult()).Value;

        public static ApiResult NotImplement { get; } = new Lazy<ApiResult>(() => new ApiResult(1000, "Not Implement")).Value;
        public static ApiResult NotFound { get; } = new Lazy<ApiResult>(() => new ApiResult(1001, "404 Not Found")).Value;
        public static ApiResult RequestError { get; } = new Lazy<ApiResult>(() => new ApiResult(1002, "请求错误")).Value;
        public static ApiResult ServerError { get; } = new Lazy<ApiResult>(() => new ApiResult(1003, "服务器错误")).Value;

        public static ApiResult ModelStateError { get; }=new Lazy<ApiResult>(() => new ApiResult(1005, "模型验证错误")).Value;
        public static ApiResult GetRequestError(string msg = "")
        {
            return new ApiResult(1002, $"请求错误:{msg}");
        }
        public static ApiResult GetServerError(string msg)
        {
            return new ApiResult(1003, $"Server Error:{msg}");
        }
        public static ApiResult GetAppTokenError(string msg = "无效的App-Token")
        {
            return new ApiResult(1004, $"App-Token错误:{msg}");
        }
        public static ApiResult GetModelStateError(string msg)
        {
            return new ApiResult(1005, $"模型验证错误:{msg}");
        }
    }

    public class ApiResult<T> : ApiResult
    {
        public ApiResult() { }
        public ApiResult(T reuslt)
        {
            Result = reuslt;
        }


        public T Result { get; set; }
    }
}


using System.Net;
using System.Text.Json;
using PmvApiService.Application.Common.Exceptions;

namespace WebAPI.Middleware
{
    public class ErrorExceptionMiddleware
    {
        public readonly RequestDelegate _next;
        private readonly IHostEnvironment _env;

        public ErrorExceptionMiddleware(RequestDelegate next,IHostEnvironment env)
        {
            _next = next;
            _env = env;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch(Exception ex) {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int) HttpStatusCode.BadRequest;
            
            var response = _env.IsDevelopment()
                    ? new AppException(context.Response.StatusCode, ex.Message, ex.StackTrace?.ToString())
                    : new AppException(context.Response.StatusCode, ex.Message);

            var options = new JsonSerializerOptions{PropertyNamingPolicy = JsonNamingPolicy.CamelCase};
          
            return context.Response.WriteAsync(JsonSerializer.Serialize(response, options));
        }
    }
}
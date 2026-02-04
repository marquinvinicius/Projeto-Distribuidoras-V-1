using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiDistribuidora.Middleware
{
    public class ErrorHandLingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandLingMiddleware> _logger;

        public ErrorHandLingMiddleware(RequestDelegate next,
            ILogger<ErrorHandLingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {

                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            _logger.LogError(ex, $"Ocorreu o erro {ex.Message}");
            var result = JsonSerializer.Serialize(new { message = "Ocorreu um erro interno do servidor" });
            return context.Response.WriteAsync(result);
        }
    }
    public static class ErrorHandlingMiddlewareExtensions
    {
        public static IApplicationBuilder UseErrorHandlingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorHandLingMiddleware>();
        }
    }
}

using ApiEcommerceWeb.Middleware;

namespace ApiEcommerceWeb.Extensions;

public static class AppExtensions
{
    public static void UseErrorHandlerMiddleware(this IApplicationBuilder app)
    {
        app.UseMiddleware<ErrorHandlerMiddleware>();
    }
}

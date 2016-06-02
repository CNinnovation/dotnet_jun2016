using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace MyFirstWebApp.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class H1Middleware
    {
        private readonly RequestDelegate _next;

        public H1Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            httpContext.Response.WriteAsync("<h1>From the Middleware</h1>");
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class H1MiddlewareExtensions
    {
        public static IApplicationBuilder UseH1Middleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<H1Middleware>();
        }
    }
}

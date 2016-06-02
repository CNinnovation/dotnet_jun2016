using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MyFirstWebApp.LocalServices;
using MyFirstWebApp.Controllers;
using MyFirstWebApp.Middleware;

namespace MyFirstWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IHelloService, HelloService>();
            services.AddTransient<HelloController>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            // app.UseH1Middleware();
            // app.UseMvcWithDefaultRoute();
            app.UseMvc(route =>
            {
                route.MapRoute("default", 
                    "{controller=Home}/{action=Index}/{id?}");
                route.MapRoute("calc",
                    "{controller=Home}/{action}/{x}/{y}");
            });

            //app.Map("/Demo1", app1 =>
            //{
            //    app1.Run(async (context) =>
            //    {
            //        await context.Response.WriteAsync("<h1>Coming from Demo1 map</h1>");
            //    });

            //});

            //app.MapWhen(context => context.Request.Path.Value.Contains("one"), app1 =>
            //{
            //    app1.Run(async (context2) =>
            //    {
            //        HelloController controller = app1.ApplicationServices.GetService<HelloController>();
            //        await context2.Response.WriteAsync(controller.Hello("ONE"));
            //    });
            //});

            //app.Map("/Hello", app1 =>
            //{
            //    app1.Run(async (context) =>
            //    {
            //        HelloController controller = app1.ApplicationServices.GetService<HelloController>();
            //        await context.Response.WriteAsync(controller.Hello("Stephanie"));
            //    });
            //});

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<h1>Hello World!</h1>");
            });
        }
    }
}

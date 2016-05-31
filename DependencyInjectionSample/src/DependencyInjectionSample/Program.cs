using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RegisterServices();
            UseWithoutContainer();
            UseWithAContainer();
        }

        private static void UseWithAContainer()
        {
            var controller = Container.GetService<HelloController>();
            controller.Greeting("Matthias");
        }

        private static void UseWithoutContainer()
        {
            var controller = new HelloController(new HelloService());
            controller.Greeting("Stephanie");
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IHelloService, HelloService>();
            services.AddTransient<HelloController>();
            Container = services.BuildServiceProvider();
        }

        public static IServiceProvider Container { get; private set; }
    }
}

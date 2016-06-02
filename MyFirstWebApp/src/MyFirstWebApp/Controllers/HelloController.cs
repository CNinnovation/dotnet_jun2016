using MyFirstWebApp.LocalServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Controllers
{
    public class HelloController
    {
        private readonly IHelloService _helloService;
        public HelloController(IHelloService helloService)
        {
            _helloService = helloService;
        }

        public string Hello(string name) =>
            $"<h1>{_helloService.Greeting(name)}</h1>";

    }
}

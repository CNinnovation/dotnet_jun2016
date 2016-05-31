using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionSample
{
    public class HelloController
    {
        private readonly IHelloService _service;
        public HelloController(IHelloService service)
        {
            _service = service;
        }

        public void Greeting(string name)
        {
            Console.WriteLine(_service.Hello(name));
        }
    }
}

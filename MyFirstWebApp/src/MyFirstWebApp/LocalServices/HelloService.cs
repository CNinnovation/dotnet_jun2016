using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.LocalServices
{
    public class HelloService : IHelloService
    {
        public string Greeting(string name) => $"Hello, {name}";

    }
}

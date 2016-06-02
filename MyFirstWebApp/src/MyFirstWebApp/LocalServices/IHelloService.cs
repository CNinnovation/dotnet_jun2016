using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.LocalServices
{
    public interface IHelloService
    {
        string Greeting(string name);
    }
}

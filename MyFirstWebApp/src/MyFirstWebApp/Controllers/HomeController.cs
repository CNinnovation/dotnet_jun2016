using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index() => $"<h2>{nameof(HomeController)}:{nameof(Index)}</h2>";

        public string Doit() => $"<h2>{nameof(HomeController)}:{nameof(Doit)}</h2>";

        public string Greeting(string id) => $"Hello, {id}";

        public int Add(int x, int y) => x + y;
    }
}

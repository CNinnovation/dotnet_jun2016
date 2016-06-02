using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstWebApp.Controllers
{
    public class MyViewController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.MyData = "From the controller";
            return View();
        }

        public IActionResult AModel()
        {
            var aBook = new Book { BookId = 1, Title = "Professional C# 6", Publisher = "Wrox Press" };
            return View(aBook);
        }

        public IActionResult MyForm()
        {
            var aBook = new Book { BookId = 1, Title = "Professional C# 6", Publisher = "Wrox Press" };
            return View(aBook);
        }

        [HttpPost]
        public string MyForm(Book b) =>
            $"received the book {b.Title} {b.Publisher}";
    }
}

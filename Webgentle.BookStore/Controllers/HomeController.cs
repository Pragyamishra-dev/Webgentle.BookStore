using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Title = "Pragya Mishra";
            dynamic data = new ExpandoObject();
            data.Id = 1;
            data.Name = "Romi Mishra";
            ViewBag.Data = data;
            //ViewBag.Data = new { Id = 1, Name = "Pragya" };
            ViewBag.Type = new BookModel() { Id = 5, Author = "Romi Mishra" };
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public  string CustomProperty { get; set; }
        [ViewData]
        public  string Title { get; set; }
        [ViewData]
        public  BookModel Book { get; set; }
        public ViewResult Index()
        {
            Title = "Home Page From Controller";
            CustomProperty = "Pragya Mishra";
            Book = new BookModel() { Id = 1, Title = "Asp.Net Core Application" };
            return View();
        }
        public ViewResult AboutUs()
        {
            Title = "About Us Page From Controller";
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}

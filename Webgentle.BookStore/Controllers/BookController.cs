using Microsoft.AspNetCore.Mvc;

namespace Webgentle.BookStore.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "All Books";
        }
        public string GetBook(int id)
        {
            return $"book with id={id}";
        }

        public string SearchBooks(string bookName,string authorName)
        {
            return $"book with name={bookName} & Author ={authorName}";
        }
    }
}

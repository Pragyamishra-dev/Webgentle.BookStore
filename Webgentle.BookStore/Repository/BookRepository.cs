using System.Collections.Generic;
using System.Linq;
using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        
        public BookModel GetBookById(int Id)
        {
            return DataSource().Where(x=>x.Id == Id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authoename)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authoename)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
        {
            new BookModel(){Id=1,Title="JAVA",Author="Priyanka"},
            new BookModel(){Id=2,Title="Machine Learning",Author="Archana",Descrption="This is The Description For MVC Book"},
            new BookModel(){Id=3,Title="Data Science",Author="Priya",Descrption="This is The Description For MVC Book"},
            new BookModel(){Id=4,Title=".NET Core and C#",Author="Pragya",Descrption="This is The Description For MVC Book"},
            new BookModel(){Id=5,Title="AI Engg.",Author="Aarya",Descrption="This is The Description For MVC Book"},
            new BookModel(){Id=5,Title="AI with Machine Learning",Author="Aary",Descrption="This is The Description For MVC Book"},
            new BookModel(){Id=5,Title="AI with Robotics",Author="Aaryan",Descrption="This is The Description For MVC Book"},

        };
    }
}

}
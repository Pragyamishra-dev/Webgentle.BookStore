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
            new BookModel(){Id=1,Title="MVC",Author="Pragya"},
            new BookModel(){Id=2,Title="Dot Net Core",Author="Priyanka"},
            new BookModel(){Id=3,Title="C#",Author="Archana"},
            new BookModel(){Id=4,Title="JAVA",Author="Pragya"},
            new BookModel(){Id=5,Title="Php",Author="Pragya"},

        };
    }
}

}
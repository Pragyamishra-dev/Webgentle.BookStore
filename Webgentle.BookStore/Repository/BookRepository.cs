using System.Collections.Generic;
using System.Linq;
using Webgentle.BookStore.Data;
using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Repository
{
    public class BookRepository
    {
        public readonly BookStoreContext _context = null;
        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }
        public int AddNewBook(BookModel model)
        {
            var newBook = new Books()
            {
                Author = model.Author,
                CreatedOn = System.DateTime.UtcNow,
                Descrption = model.Descrption,
                Title = model.Title,
                TotalPages = model.TotalPages,
                UpdatedOn = System.DateTime.UtcNow,
            };
            _context.Books.Add(newBook);
            _context.SaveChanges();
            return newBook.Id;
        }
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
            new BookModel(){Id=1,Title="JAVA",Author="Priyanka",Descrption="This is The Description For MVC Book",Category="Pragramming",Language="English",TotalPages=134},
            new BookModel(){Id=2,Title="Machine Learning",Author="Archana",Descrption="This is The Description For MVC Book",Category="Framework",Language="Chinese",TotalPages=567},
            new BookModel(){Id=3,Title="Data Science",Author="Priya",Descrption="This is The Description For MVC Book",Category="Pragramming",Language="English",TotalPages=100},
            new BookModel(){Id=4,Title=".NET Core and C#",Author="Pragya",Descrption="This is The Description For MVC Book",Category="Concept",Language="English",TotalPages=800},
            new BookModel(){Id=5,Title="AI Engg.",Author="Aarya",Descrption="This is The Description For MVC Book",Category="Pragramming",Language="English",TotalPages=100},
            new BookModel(){Id=5,Title="AI with ML",Author="Aary",Descrption="This is The Description For MVC Book",Category="Pragramming",Language="English",TotalPages=100},
            new BookModel(){Id=5,Title="AI with Robotics",Author="Aaryan",Descrption="This is The Description For MVC Book",Category="Pragramming",Language="English",TotalPages=100},

        };
    }
}

}
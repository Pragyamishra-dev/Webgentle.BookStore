using Microsoft.EntityFrameworkCore;

namespace Webgentle.BookStore.Data
{
    public class BookStoreContext:DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            :base(options)
        {

        }

        public DbSet<Books> Books { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server= DESKTOP-FKJPP8L\\SQLEXPRESS; User id=sa; password=info; Database=BookStore;MultipleActiveResultSets=true");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}

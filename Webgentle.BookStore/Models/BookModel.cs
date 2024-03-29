﻿namespace Webgentle.BookStore.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Descrption { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public int TotalPages { get; set; }
    }
}

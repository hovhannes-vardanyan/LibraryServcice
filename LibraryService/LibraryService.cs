using Books;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LibraryService
{
    
    public class LibraryService : ILibrayService
    {
        List<Book> Books = new List<Book>();
        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void PrintAllBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine($"BookID:{book.ID}");
                Console.WriteLine($"BookAuthor:{book.Author}");
                Console.WriteLine($"BookTitle:{book.Title}");
                Console.WriteLine($"BookYear:{book.Year}");
                Console.WriteLine($"BookPrice:{book.Price}");
            }
        }

        public void UpdateBookPrice(Book book, int Price)
        {
            book.Price = Price;
        }
        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }
    }
}

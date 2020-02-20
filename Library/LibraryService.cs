using System;
using Books;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LibraryService
{
   
    public class Service1 : IService1
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
                Console.WriteLine($"Book Author:{book.Author}");
                Console.WriteLine($"Book Title:{book.Title}");
                Console.WriteLine($"Book Price:{book.Price}");
                Console.WriteLine($"Book Year:{book.Year}");

            }
        }

        
        public void UpdateBookPrice(Book book,int newPrice)
        {
            book.Price = newPrice;
        }
    }
}

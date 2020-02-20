using Client.ServiceReference1;
using LibraryService;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");

            LibrayServiceClient client = new LibrayServiceClient();
            // client.AddBook();
            client.PrintAllBooks();
            //  client.UpdateBookPrice();



            Console.ReadKey();
        }
    }
}

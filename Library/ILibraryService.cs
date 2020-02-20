using Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace LibraryService
{
    
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        public void AddBook(Book book);
        [OperationContract]
        public void UpdateBookPrice(Book book,int Price);
        [OperationContract]
        public void PrintAllBooks();

    }

}

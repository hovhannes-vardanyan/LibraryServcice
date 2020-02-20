using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Author { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public int Year { get; set; }

        
      
       
        public Book(int id, string author, string title, int price, int year)
        {
            this.ID = id;
            this.Author = author;
            this.Title = title;
            this.Price = price;
            this.Year = year;
        }
    }
}

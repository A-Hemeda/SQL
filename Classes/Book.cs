using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int TotalCopies { get; set; }
        public int AvilableCooies { get; set; }

        public Book(string title,string author,string isbn ,int totalcopies)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            TotalCopies = totalcopies;
            AvilableCooies = totalcopies;
            
        }

        public void UpdateBookInfo(string title,string author)
        {
            Title = title;
            Author = author;
        }

        public bool CheckAvailability()
        {
            return AvilableCooies > 0;
        }


    }
}

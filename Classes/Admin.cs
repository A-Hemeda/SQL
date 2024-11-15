using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Admin:User
    {
        public Admin(string name, string id):base(name, id) { }
        
        public void AddBook(Library library, Book book)
        {
            library.books.Add(book);
            Console.WriteLine($"Book '{book.Title}' Added to the Library");

        }

        public void RemoveBook(Library library, Book book)
        {
            library.books.Remove(book);
            Console.WriteLine($"Book '{book.Title}' Removed from the Library");

        }

    }
}

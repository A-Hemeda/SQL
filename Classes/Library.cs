using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Library
    {
        public List<Book> books { get; set; }
        public List<User> users { get; set; }

        public Library()
        { 
            books = new List<Book>();
            users = new List<User>();
        }

        public void RegisterUser(User user)
        {
            users.Add(user);
            Console.WriteLine($"User '{user.UserName}' Registered");

        }

        public void DisplayAvailableBooks() 
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Title} by {book.Author} - AvailableCopies: {book.AvilableCooies}");

            }
        }
    }
}

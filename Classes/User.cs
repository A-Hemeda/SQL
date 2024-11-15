using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class User
    {
        public string UserId { get; set; }
        public string UserName { get; set; }

        public List<BorrowBooks> borrowHistory { get; set; }

        public User(string name,string id)
        {
            UserName = name;
            UserId = id;
            borrowHistory=new List<BorrowBooks>();
        }

        public void BorrowBookFromLibrary(Book book)
        {
            if(book.CheckAvailability())
            {
                book.AvilableCooies--;
                var Transaction = new BorrowBooks(book, this, DateTime.Now);
                borrowHistory.Add(Transaction);
                Console.WriteLine($"{UserName} borrowed '{book.Title}'");
            }
            else
            {
                Console.WriteLine($"'{book.Title}' is Currently UnAvailable");

            }

            

        }

        public void ReturnBook(Book book)
        {
            book.AvilableCooies++;
            Console.WriteLine($"{UserName} Returned '{book.Title}");
            }
    }
}

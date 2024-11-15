using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class BorrowBooks
    {
        public Book book { get; private set; }
        public User user { get;private set; }
        public DateTime BorrowDate { get;private set; }
        public DateTime DueDate { get; set; }
        public BorrowBooks(Book book, User user, DateTime borrowDate)
        {
            this.book = book;
            this.user = user;
            BorrowDate = borrowDate;
            DueDate = BorrowDate.AddDays(10);
        }
    }
}

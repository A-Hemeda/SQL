using Classes;

namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();

            var admin = new Admin("Admin User", "A001");
            library.RegisterUser(admin);

            var book1 = new Book("1984", "George Orwell", "123456789", 5);
            var book2 = new Book("To Kill a Mockingbird", "Harper Lee", "987654321", 3);

            admin.AddBook(library, book1);
            admin.AddBook(library, book2);

            var user = new User("John Doe", "U001");
            library.RegisterUser(user);

            library.DisplayAvailableBooks();

            user.BorrowBookFromLibrary(book1);
            user.BorrowBookFromLibrary(book2);

            library.DisplayAvailableBooks();

            user.ReturnBook(book1);

            library.DisplayAvailableBooks();


        }
    }
}
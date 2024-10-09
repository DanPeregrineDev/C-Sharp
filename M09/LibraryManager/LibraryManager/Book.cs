using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    internal class Book
    {
        // Data

        private static List<Book> bookList = new List<Book>();

        // Proprieties

        private string bookName;
        private string bookAuthor;

        private User bookLeaser;

        private int bookID;

        private bool isBookAvailable;

        // Functions

        // Asks for the book information and returns a adds it to the book list
        public static void createBook()
        {
            Console.Clear();

            // Book's name
            Console.WriteLine("Nome do livro");

            Console.Write("\n> ");
            string bookName = Console.ReadLine();

            // Book's author
            Console.WriteLine("\nAutor do livro");

            Console.Write("\n> ");
            string bookAuthor = Console.ReadLine();

            // Create the book object
            Book newBook = new Book();

            newBook.bookName = bookName;
            newBook.bookAuthor = bookAuthor;
            newBook.bookLeaser = null;
            newBook.bookID = 0;
            newBook.isBookAvailable = true;

            bookList.Add(newBook);
        }

        private static void leaseBook()
        {
            
        }
    }
}

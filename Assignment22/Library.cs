using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22
{
    internal class Library
    {
        private List<Book> bookList = new List<Book>();
        public void AddBook(Book newBook)
        {
            bookList.Add(newBook);
            Console.WriteLine("Book added successfully!");
        }

        public void ViewAllBooks()
        {
            Console.WriteLine("List of all books in the library:");
            foreach (var book in bookList)
            {
                Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.IsAvailable}");
            }
        }
        public void SearchBookById(int bookId)
        {
            var book = bookList.Find(b => b.BookId == bookId);
            if (book != null)
            {
                Console.WriteLine($"Book found - ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.IsAvailable}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
        public void SearchBookByTitle(string title)
        {
            var book = bookList.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                Console.WriteLine($"Book found - ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.IsAvailable}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
    }

}

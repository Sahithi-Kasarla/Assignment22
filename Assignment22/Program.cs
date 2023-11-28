using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("\nLibrary Management System\n");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Search by Book ID");
                Console.WriteLine("4. Search by Title");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter book ID: ");
                        int bookId = int.Parse(Console.ReadLine());
                        Console.Write("Enter book title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter genre: ");
                        string genre = Console.ReadLine();
                        Console.Write("Is the book available? (true/false): ");
                        bool isAvailable = bool.Parse(Console.ReadLine());

                        Book newBook = new Book
                        {
                            BookId = bookId,
                            Title = title,
                            Author = author,
                            Genre = genre,
                            IsAvailable = isAvailable
                        };

                        library.AddBook(newBook);
                        break;

                    case "2":
                        library.ViewAllBooks();
                        break;

                    case "3":
                        Console.Write("Enter the book ID to search: ");
                        int searchBookId = int.Parse(Console.ReadLine());
                        library.SearchBookById(searchBookId);
                        break;

                    case "4":
                        Console.Write("Enter the title to search: ");
                        string searchTitle = Console.ReadLine();
                        library.SearchBookByTitle(searchTitle);
                        break;

                    case "5":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
        }
    }
}

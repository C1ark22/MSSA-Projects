using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = new BooksContext();

            // Create the database and tables if they don't exist.
            db.Database.EnsureCreated();

            long isbn = 9780140328721;

            // Find searches by primary key, which is ISBN.
            Books? existingBook = db.Books.Find(isbn);

            // Only add this sample book if it isn't already stored.
            if (existingBook == null)
            {
                Books newBook = new Books   
                {
                    ISBN = isbn,
                    Name = "Matilda",
                    Author = "Roald Dahl",
                    Description = "A gifted girl discovers extraordinary abilities."
                };

                // Track the new book, then save it to the database.
                db.Books.Add(newBook);
                db.SaveChanges();
            }

            // Read the saved books into a list in memory.
            List<Books> books = db.Books.ToList();

            Console.WriteLine("BOOK INVENTORY");
            Console.WriteLine();

            foreach (Books book in books)
            {
                Console.WriteLine($"ISBN: {book.ISBN}");
                Console.WriteLine($"Name: {book.Name}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Description: {book.Description}");
                Console.WriteLine();
            }

            Console.WriteLine("Press Enter to close.");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Assignment_11._1
{
    public class BooksContext : DbContext
    {
        public DbSet<Books> Books { get; set; }
        public string DbPath { get; }
        public BooksContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);

            DbPath = Path.Join(path, "books.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>().HasData(
                new Books
                {
                    ISBN = 9780131103627,
                    Name = "The C Programming Language",
                    Author = "Brian W. Kernighan and Dennis M. Ritchie",
                    Description = "A classic book on the C programming language."
                },
                new Books
                {
                    ISBN = 9780201633610,
                    Name = "Design Patterns: Elements of Reusable Object-Oriented Software",
                    Author = "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides",
                    Description = "A foundational book on software design patterns."
                },
                new Books
                {
                    ISBN = 9780132350884,
                    Name = "Clean Code: A Handbook of Agile Software Craftsmanship",
                    Author = "Robert C. Martin",
                    Description = "A guide to writing clean and maintainable code."
                }
            );
        }

    }
}

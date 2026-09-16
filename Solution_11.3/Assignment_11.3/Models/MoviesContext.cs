using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Assignment_11._3.Models
{
    public class MoviesContext : DbContext
    {
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Movies_Genre> Movies_Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=movies.db");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Tell EF Core which properties are the primary keys
            modelBuilder.Entity<Movies>()
                .HasKey(movie => movie.MovieId);

            modelBuilder.Entity<Movies_Genre>()
                .HasKey(genre => genre.GenreId);

            // Keep your existing movie and genre HasData code below

            modelBuilder.Entity<Movies>().HasData(
                new Movies { MovieId = 1, Title = "The Shawshank Redemption", ReleaseYear = 1994, GenreId = 1 },
                new Movies { MovieId = 2, Title = "The Godfather", ReleaseYear = 1972, GenreId = 1 },
                new Movies { MovieId = 3, Title = "The Dark Knight", ReleaseYear = 2008, GenreId = 2 },
                new Movies { MovieId = 4, Title = "Pulp Fiction", ReleaseYear = 1994, GenreId = 3 },
                new Movies { MovieId = 5, Title = "Forrest Gump", ReleaseYear = 1994, GenreId = 4 },
                new Movies { MovieId = 6, Title = "Inception", ReleaseYear = 2010, GenreId = 2 },
                new Movies { MovieId = 7, Title = "The Matrix", ReleaseYear = 1999, GenreId = 2 },
                new Movies { MovieId = 8, Title = "The Silence of the Lambs", ReleaseYear = 1991, GenreId = 3 },
                new Movies { MovieId = 9, Title = "The Green Mile", ReleaseYear = 1999, GenreId = 1 },
                new Movies { MovieId = 10, Title = "The Godfather Part II", ReleaseYear = 1974, GenreId = 1 },
                new Movies { MovieId = 11, Title = "The Pursuit of Happyness", ReleaseYear = 2006, GenreId = 1 },
                new Movies { MovieId = 12, Title = "Rocky", ReleaseYear = 1976, GenreId = 1 },
                new Movies { MovieId = 13, Title = "Gladiator", ReleaseYear = 2000, GenreId = 2 },
                new Movies { MovieId = 14, Title = "John Wick", ReleaseYear = 2014, GenreId = 2 },
                new Movies { MovieId = 15, Title = "Mad Max: Fury Road", ReleaseYear = 2015, GenreId = 2 },
                new Movies { MovieId = 16, Title = "Die Hard", ReleaseYear = 1988, GenreId = 2 },
                new Movies { MovieId = 17, Title = "Se7en", ReleaseYear = 1995, GenreId = 3 },
                new Movies { MovieId = 18, Title = "Shutter Island", ReleaseYear = 2010, GenreId = 3 },
                new Movies { MovieId = 19, Title = "Gone Girl", ReleaseYear = 2014, GenreId = 3 },
                new Movies { MovieId = 20, Title = "Zodiac",ReleaseYear = 2007,GenreId = 3 },
                new Movies { MovieId = 21, Title = "Bridesmaids", ReleaseYear = 2011, GenreId = 4 }
            );

            modelBuilder.Entity<Movies_Genre>().HasData(
                new Movies_Genre { GenreId = 1, GenreName = "Drama" },
                new Movies_Genre { GenreId = 2, GenreName = "Action/Thriller" },
                new Movies_Genre { GenreId = 3, GenreName = "Crime" },
                new Movies_Genre { GenreId = 4, GenreName = "Comedy" }
            );
        }
    }
}

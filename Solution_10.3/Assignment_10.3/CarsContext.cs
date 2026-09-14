using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Assignment_10._3
{
    public class CarsContext : DbContext
    {
        // Represents the Cars table.
        public DbSet<Car> Cars { get; set; }

        public string DbPath { get; }

        public CarsContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);

            DbPath = Path.Join(path, "cars.db");
        }

        protected override void OnConfiguring(
            DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    CarID = 1,
                    VIN = "TESTVIN0000000001",
                    Make = "Toyota",
                    Model = "Camry",
                    Year = 2020,
                    Price = 28000m
                },
                new Car
                {
                    CarID = 2,
                    VIN = "TESTVIN0000000002",
                    Make = "Honda",
                    Model = "Civic",
                    Year = 2021,
                    Price = 25000m
                },
                new Car
                {
                    CarID = 3,
                    VIN = "TESTVIN0000000003",
                    Make = "Ford",
                    Model = "Focus",
                    Year = 2022,
                    Price = 22000m
                },
                new Car
                {
                    CarID = 4,
                    VIN = "TESTVIN0000000004",
                    Make = "BMW",
                    Model = "X5",
                    Year = 2023,
                    Price = 50000m
                },
                new Car
                {
                    CarID = 5,
                    VIN = "TESTVIN0000000005",
                    Make = "Audi",
                    Model = "A4",
                    Year = 2023,
                    Price = 45000m
                },
                new Car
                {
                    CarID = 6,
                    VIN = "TESTVIN0000000006",
                    Make = "Mercedes",
                    Model = "C-Class",
                    Year = 2023,
                    Price = 48000m
                });
        }
    }
}

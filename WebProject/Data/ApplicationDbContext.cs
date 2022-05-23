using Microsoft.EntityFrameworkCore;
using System;
using WebProject.Models;

namespace WebProject.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Seeding
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    ID = Guid.NewGuid(),
                    Name = "Jane Doe",
                    City = "Los Angeles",
                    PhoneNumber = "555-123 45"
                });

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    ID = Guid.NewGuid(),
                    Name = "John Doe",
                    City = "Chicago",
                    PhoneNumber = "555-123 45"
                });

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    ID = Guid.NewGuid(),
                    Name = "Janelle Monáe",
                    City = "Kansas",
                    PhoneNumber = "555-5555"
                });

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    ID = Guid.NewGuid(),
                    Name = "Marge Simpson",
                    City = "Springfield",
                    PhoneNumber = "939-555-0113"
                });

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    ID = Guid.NewGuid(),
                    Name = "Somna Sculpt",
                    City = "Dreamland",
                    PhoneNumber = "1-555-766728578"
                });

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    ID = Guid.NewGuid(),
                    Name = "Anthony Hopkins",
                    City = "Pittsburgh",
                    PhoneNumber = "555-6162"
                });

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    ID = Guid.NewGuid(),
                    Name = "Saul Goodman",
                    City = "Albuquerque",
                    PhoneNumber = "505-842-5662"
                });
            #endregion
        }

        public DbSet<Person> People { get; set; }
    }
}

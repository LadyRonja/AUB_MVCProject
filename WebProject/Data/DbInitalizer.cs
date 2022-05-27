using WebProject.Models;
using System;
using System.Linq;

namespace WebProject.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any people.
            if (context.People.Any())
            {
                return;   // DB has been seeded
            }

            var people = new Person[]
            {
             new Person{ID = Guid.NewGuid(),Name = "John Doe",City = "Chicago",PhoneNumber = "555-123 45"},
             new Person{ID = Guid.NewGuid(),Name = "Jane Doe",City = "Los Angles",PhoneNumber = "555-678 90"},
             new Person{ID = Guid.NewGuid(),Name = "Janelle Monáe",City = "Kansas",PhoneNumber = "555-5555"},
             new Person{ID = Guid.NewGuid(),Name = "Marge Simpson",City = "Springfield",PhoneNumber = "939-555-0113"},
             new Person{ID = Guid.NewGuid(),Name = "Somna Sculpt",City = "Dreamland",PhoneNumber = "1-555-766728578"},
             new Person{ID = Guid.NewGuid(),Name = "Anthony Hopkins",City = "Pittsburgh",PhoneNumber = "555-6162"},
             new Person{ID = Guid.NewGuid(),Name = "Saul Goodman",City = "Albuquerque",PhoneNumber = "505-842-5662"},
            };
            foreach (Person p in people)
            {
                context.People.Add(p);
            }

            context.SaveChanges();
        }
    }
}
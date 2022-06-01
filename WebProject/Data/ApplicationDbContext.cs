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
            Guid[] countryIDs =  new Guid[]{    Guid.NewGuid(),
                                                Guid.NewGuid(),
                                                Guid.NewGuid(),
                                                };

            Guid[] cityIds = new Guid[]{    Guid.NewGuid(),
                                            Guid.NewGuid(),
                                            Guid.NewGuid(),
                                            Guid.NewGuid(),
                                            Guid.NewGuid(),
                                            Guid.NewGuid() 
                                            };

            #region Contries Seeding
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    ID = countryIDs[0],
                    Name = "Sweden"
                },
                new Country
                {
                    ID = countryIDs[1],
                    Name = "Germany"
                },
                new Country
                {
                    ID = countryIDs[2],
                    Name = "USA"
                });

            #endregion

            #region Cities Seeding
            modelBuilder.Entity<City>()
                .HasOne(e => e.Country)
                .WithMany(e => e.Cities);

            modelBuilder.Entity<City>().HasData(
                 new City
                 {
                     ID = cityIds[0],
                     Name = "Los Angeles",
                     CountryID = countryIDs[2]
                 },
                 new City
                 {
                     ID = cityIds[1],
                     Name = "Chicago",
                     CountryID = countryIDs[2]
                 },
                 new City
                 {
                     ID = cityIds[2],
                     Name = "Springfield",
                     CountryID = countryIDs[2]
                 },
                 new City
                 {
                     ID = cityIds[3],
                     Name = "Dreamland",
                     CountryID = countryIDs[1]
                 },
                 new City
                 {
                     ID = cityIds[4],
                     Name = "Borås",
                     CountryID = countryIDs[0]
                 }, new City
                 {
                     ID = cityIds[5],
                     Name = "Albuquerque",
                     CountryID = countryIDs[2]
                 });

            #endregion


            #region People Seeding
            modelBuilder.Entity<Person>()
                    .HasOne(c => c.City)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(k => k.CityID);

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    ID = Guid.NewGuid(),
                    Name = "Jane Doe",
                    CityID = cityIds[0],
                    PhoneNumber = "555-123 45"
                });

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    ID = Guid.NewGuid(),
                    Name = "John Doe",
                    CityID = cityIds[1],
                    PhoneNumber = "555-123 45"
                });


            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    ID = Guid.NewGuid(),
                    Name = "Marge Simpson",
                    CityID = cityIds[2],
                    PhoneNumber = "939-555-0113"
                });

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    ID = Guid.NewGuid(),
                    Name = "Somna Sculpt",
                    CityID = cityIds[3],
                    PhoneNumber = "1-555-766728578"
                });

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    ID = Guid.NewGuid(),
                    Name = "Anthony Hopkins",
                    CityID = cityIds[4],
                    PhoneNumber = "555-6162"
                });

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    ID = Guid.NewGuid(),
                    Name = "Saul Goodman",
                    CityID = cityIds[5],
                    PhoneNumber = "505-842-5662"
                });


            #endregion

        }

        public DbSet<Person> People { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}

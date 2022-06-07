using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using WebProject.Models;

namespace WebProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Guid[] countryIDs =  new Guid[]{    Guid.NewGuid(),
                                                Guid.NewGuid(),
                                                Guid.NewGuid()
                                                };

            Guid[] cityIDs = new Guid[]{    Guid.NewGuid(),
                                            Guid.NewGuid(),
                                            Guid.NewGuid(),
                                            Guid.NewGuid(),
                                            Guid.NewGuid(),
                                            Guid.NewGuid() 
                                            };

            Guid[] peopleIDs = new Guid[] { Guid.NewGuid(),     
                                            Guid.NewGuid(),
                                            Guid.NewGuid(),
                                            Guid.NewGuid(),
                                            Guid.NewGuid(),
                                            Guid.NewGuid()
            };

            Guid[] languageIDs = new Guid[] { Guid.NewGuid(),
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

            // Create one-to-many connection between City and Country
            modelBuilder.Entity<City>()
                .HasOne(e => e.Country)
                .WithMany(e => e.Cities)
                .HasForeignKey(e => e.CountryID);
            #region Cities Seeding
            modelBuilder.Entity<City>().HasData(
                 new City
                 {
                     ID = cityIDs[0],
                     Name = "Los Angeles",
                     CountryID = countryIDs[2]
                 },
                 new City
                 {
                     ID = cityIDs[1],
                     Name = "Chicago",
                     CountryID = countryIDs[2]
                 },
                 new City
                 {
                     ID = cityIDs[2],
                     Name = "Springfield",
                     CountryID = countryIDs[2]
                 },
                 new City
                 {
                     ID = cityIDs[3],
                     Name = "Dreamland",
                     CountryID = countryIDs[1]
                 },
                 new City
                 {
                     ID = cityIDs[4],
                     Name = "Borås",
                     CountryID = countryIDs[0]
                 }, new City
                 {
                     ID = cityIDs[5],
                     Name = "Albuquerque",
                     CountryID = countryIDs[2]
                 });
            #endregion
            
            // Create one-to-many connection between Person and City
            modelBuilder.Entity<Person>()
                    .HasOne(c => c.City)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(k => k.CityID);
            #region People Seeding
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    ID = peopleIDs[0],
                    Name = "Jane Doe",
                    CityID = cityIDs[0],
                    PhoneNumber = "555-123 45"
                });

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    ID = peopleIDs[1],
                    Name = "John Doe",
                    CityID = cityIDs[1],
                    PhoneNumber = "555-123 45"
                });

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    ID = peopleIDs[2],
                    Name = "Marge Simpson",
                    CityID = cityIDs[2],
                    PhoneNumber = "939-555-0113"
                });

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    ID = peopleIDs[3],
                    Name = "Somna Sculpt",
                    CityID = cityIDs[3],
                    PhoneNumber = "1-555-766728578"
                });

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    ID = peopleIDs[4],
                    Name = "Anthony Hopkins",
                    CityID = cityIDs[4],
                    PhoneNumber = "555-6162"
                });

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    ID = peopleIDs[5],
                    Name = "Saul Goodman",
                    CityID = cityIDs[5],
                    PhoneNumber = "505-842-5662"
                });
            #endregion

            #region Language Seeding
            modelBuilder.Entity<Language>().HasData(
            new Language
            {
                ID = languageIDs[0],
                Name = "English"
            },
            new Language
            {
                ID = languageIDs[1],
                Name = "Swedish"
            },
            new Language
            {
                ID = languageIDs[2],
                Name = "German"
            },
            new Language
            {
                ID = languageIDs[3],
                Name = "C#"
            });
            #endregion

            // --- Create a many-to-many connection perople Person and Language
            // --- Using a connector class named LanguagePerson

            // Denote composite key
            modelBuilder.Entity<LanguagePerson>()
                .HasKey(lp => new { lp.LanguageID, lp.PersonID });

            // Create one-to-many connection beteween connector and Language
            modelBuilder.Entity<LanguagePerson>()
                .HasOne(l => l.Language)
                .WithMany(s => s.Speakers)
                .HasForeignKey(l => l.LanguageID);

            // Create one-to-many connection beteween connector and Person
            modelBuilder.Entity<LanguagePerson>()
                .HasOne(s => s.Speaker)
                .WithMany(l => l.Languages)
                .HasForeignKey(p => p.PersonID);
            #region Language Speakers Seeding
            modelBuilder.Entity<LanguagePerson>().HasData(
                // Jane
                new LanguagePerson
                {
                    LanguageID = languageIDs[0],
                    PersonID = peopleIDs[0]
                },
                // John
                new LanguagePerson
                {
                    LanguageID = languageIDs[0],
                    PersonID = peopleIDs[1]
                },
                // Marge                
                new LanguagePerson
                {
                    LanguageID = languageIDs[0],
                    PersonID = peopleIDs[2]
                },
                // Somna                
                new LanguagePerson
                {
                    LanguageID = languageIDs[2],
                    PersonID = peopleIDs[3]
                },
                new LanguagePerson
                {
                    LanguageID = languageIDs[3],
                    PersonID = peopleIDs[3]
                },

                // Anthony                
                new LanguagePerson
                {
                    LanguageID = languageIDs[0],
                    PersonID = peopleIDs[4]
                },
                new LanguagePerson
                {
                    LanguageID = languageIDs[2],
                    PersonID = peopleIDs[4]
                },
                new LanguagePerson
                {
                    LanguageID = languageIDs[1],
                    PersonID = peopleIDs[4]
                },
                // Saul                
                new LanguagePerson
                {
                    LanguageID = languageIDs[0],
                    PersonID = peopleIDs[5]
                }
                );
            #endregion

        }

        public DbSet<Person> People { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<LanguagePerson> LanguageSpeakers { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
    }
}

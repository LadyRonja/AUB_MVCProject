using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Data;

namespace WebProject.Models
{
    public class CityFactory
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string CountryID { get; set; }

        public void AddCityToDataBase(ApplicationDbContext context)
        {
            City cityToAdd = new City
            {
                Name = this.Name,
                CountryID = Guid.Parse(this.CountryID)
            };

            context.Cities.Add(cityToAdd);
            context.SaveChanges();
        }
    }
}

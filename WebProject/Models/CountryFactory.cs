using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Data;

namespace WebProject.Models
{
    public class CountryFactory
    {
        [Required]
        public string Name { get; set; }

        public void AddCountryToDatabase(ApplicationDbContext context)
        {
            Country countryToAdd = new Country
            {
                Name = this.Name,
                ID = Guid.NewGuid()
            };

            context.Countries.Add(countryToAdd);
            context.SaveChanges();
        }
    }
}

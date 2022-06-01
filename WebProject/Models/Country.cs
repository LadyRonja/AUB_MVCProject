using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class Country
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public string Name { get; set; }
        
        public List<City> Cities { get; set; }

        public Country(string name, List<City> cities)
        {
            ID = Guid.NewGuid();
            Name = name;
            Cities = cities;
        }
        public Country()
        {
        }

    }
}

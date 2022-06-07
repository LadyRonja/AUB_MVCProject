using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class City
    { 
        [Key]
        public Guid ID { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Person> Citizens { get; set; }

        [Required]
        public Guid CountryID { get; set; }
        public Country Country { get; set; }

        public City()
        {

        }
    }
}

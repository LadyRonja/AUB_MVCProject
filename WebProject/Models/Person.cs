using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class Person
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Guid CityID { get; set; }
        public City City { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public List<LanguagePerson> Languages { get; set; }

        public Person()
        {

        }
    }
}

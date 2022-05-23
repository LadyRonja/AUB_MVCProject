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
        public string City { get; set; }

        [Required]
        public string PhoneNumber { get; set; }


        public Person(string name, string city, string number)
        {
            ID = Guid.NewGuid();
            Name = name;
            City = city;
            PhoneNumber = number;
        }
        public Person()
        {

        }
    }
}

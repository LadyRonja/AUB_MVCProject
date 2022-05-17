using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }

        public Person(string name, string city, string number)
        {
            Name = name;
            City = city;
            PhoneNumber = number;
        }
    }
}

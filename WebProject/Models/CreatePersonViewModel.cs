using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Data;

namespace WebProject.Models
{
    public class CreatePersonViewModel
    {

        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Number { get; set; }

        public void AddPersonToDataBase(ApplicationDbContext context)
        {
            Person personToAdd = new Person(Name, City, Number);
            context.Add(personToAdd);
            context.SaveChanges();
        }
    }
}

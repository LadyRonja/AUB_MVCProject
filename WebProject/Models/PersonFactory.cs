using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Data;

namespace WebProject.Models
{
    public class PersonFactory
    {

        [Required]
        public string Name { get; set; }
        [Required]
        public string CityID { get; set; }
        [Required]
        public string Number { get; set; }

        public void AddPersonToDataBase(ApplicationDbContext context)
        {
            Person personToAdd = new Person {   Name = this.Name,
                                                CityID = Guid.Parse(this.CityID),
                                                PhoneNumber = this.Number };

            context.People.Add(personToAdd);
            context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class PeopleViewModel
    {
        private  List<Person> defaultList = new List<Person>()
        {
            new Person("Janelle Monáe", "Kansas", "555-5555"),
            new Person("Marge Simpson", "Springfield", "939-555-0113"),
            new Person("Somna Sculpt", "Dreamland", "1-555-766728578"),
            new Person("Anthony Hopkins", "Pittsburgh", "555-6162"),
            new Person("Saul Goodman", "Albuquerque", "505-842-5662"),
        };

       public CreatePersonViewModel PersonFactory { get; set; }

       public List<Person> AllPeople { get; set; }
       public string Filter { get; set; }

        public PeopleViewModel()
        {
            AllPeople = new List<Person>(defaultList);
            PersonFactory = new CreatePersonViewModel();
        }
    }
}

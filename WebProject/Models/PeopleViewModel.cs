using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class PeopleViewModel
    {
       public CreatePersonViewModel PersonFactory { get; set; }
       public List<Person> AllPeople { get; set; }
       public string Filter { get; set; }

        public PeopleViewModel()
        {
            PersonFactory = new CreatePersonViewModel();
        }
    }
}

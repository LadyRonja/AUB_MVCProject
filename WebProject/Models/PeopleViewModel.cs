using System.Collections.Generic;

namespace WebProject.Models
{
    public class PeopleViewModel
    {
       public PersonFactory PersonFactory { get; set; }
       public List<Person> AllPeople { get; set; }
        public string Filter { get; set; }

        public PeopleViewModel()
        {
            PersonFactory = new PersonFactory();
        }
    }
}

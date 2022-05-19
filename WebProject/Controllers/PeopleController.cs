using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class PeopleController : Controller
    {
        // Use reference to viewmodel as backend/database
        public static PeopleViewModel database = new PeopleViewModel();

        public IActionResult PeopleTable()
        {
            return View(database);
        }

        [HttpPost]
        public IActionResult Search(PeopleViewModel model)
        {
            database.Filter = model.Filter;
            return View("PeopleTable", database);
        }

       [HttpPost]
       public IActionResult CreatePerson(PeopleViewModel model)
       {
            if (ModelState.IsValid)
            {
                database.AllPeople.Add(new Person(model.PersonFactory.Name, model.PersonFactory.City, model.PersonFactory.Number));
            }
           return View("PeopleTable", database);
       }

        [HttpPost]
         public IActionResult RemovePerson(string index)
         {
            for (int i = 0; i < database.AllPeople.Count; i++)
            {
                string idCompare = database.AllPeople[i].Name + database.AllPeople[i].City + database.AllPeople[i].PhoneNumber;
                if (index.Equals(idCompare))
                {
                    database.AllPeople.RemoveAt(i);
                    break;
                }
            }

             return View("PeopleTable", database);
         }
    }
}

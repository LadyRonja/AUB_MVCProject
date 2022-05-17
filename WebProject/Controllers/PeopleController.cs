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
         public IActionResult RemovePerson(int index)
         {
             database.AllPeople.RemoveAt(index);

             return View("PeopleTable", database);
         }
    }
}

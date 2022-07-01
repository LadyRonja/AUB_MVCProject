using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Data;
using WebProject.Models;

namespace WebProject.Controllers
{

    public class ReactController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ReactController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetPeopleList()
        {
            List<Person> people = _context.People.ToList();

            return Json(people);
        }

        public ActionResult GetCities()
        {
            List<City> cities = _context.Cities.ToList();

            return Json(cities);
        }

        [HttpPost]
        public ActionResult CreatePerson(string name, string cityID, string number)
        {
            bool personAdded = false;

            string na = name;
            string c = cityID;
            string nu = number;

            try
            {
                Person personToAdd = new Person
                {
                    ID = Guid.NewGuid(),
                    Name = na,
                    CityID = Guid.Parse(c),
                    PhoneNumber = nu
                };
                _context.Add(personToAdd);
                _context.SaveChanges();
                personAdded = true;
            }
            catch (NullReferenceException)
            {
                // No handling in catch
                throw;
            }

            if (personAdded)
            {
                return StatusCode(201); // Created
            }
            else
            {
                // Could be improved to return different status codes depending on error
                return BadRequest();
            }
        }

       
        public ActionResult GetPersonDetails(string personID)
        {
            Person p = _context.People.Find(Guid.Parse(personID));

            if (p == null)
            {
                return Json("");
            }
            // Find the city matching the person requested
            p.City = _context.Cities.Find(p.CityID);

            // Find the country matching the persons city
            Country personsCountry = _context.Countries.Where(c => c.Cities.Contains(p.City)).First();

            // Find the language instance corresponding with the language ID,
            // Conenct it to the languagePerson then add the instance
            List<LanguagePerson> languages = _context.LanguageSpeakers.Where(l => l.PersonID == p.ID).ToList();
            string[] langs = new string[0];
            if (languages != null && languages.Count != 0)
            {
                langs = new string[p.Languages.Count];
                for (int l = 0; l < languages.Count; l++)
                {
                    languages[l].Language = _context.Languages.Find(languages[l].LanguageID);
                    langs[l] = languages[l].Language.Name;
                }
            }

            p.Languages = new List<LanguagePerson>(languages);


            JsonPerson jp = new JsonPerson(p.ID.ToString(), p.Name, p.City.Name,personsCountry.Name, langs);

            return Json(jp);
        }

        public ActionResult DeletePerson(string id)
        {
            bool deleteAccepted = false;

            Person personToDelete = _context.People.Find(Guid.Parse(id));

            if (personToDelete != null)
            {
                _context.People.Remove(personToDelete);
                _context.SaveChanges();
                deleteAccepted = true;
            }

            if (deleteAccepted)
            {
                return StatusCode(202); //Accepted
            }
            else
            {
                return BadRequest();
            }
        }

        private class JsonPerson
        {
            public JsonPerson(string id, string name, string city, string country, string[] languages)
            {
                this.id = id;
                this.name = name;
                this.city = city;
                this.country = country;
                this.ls = languages;
            }

            public string id;
            public string name;
            public string city;
            public string country;
            public string[] ls;
        }
    }
}

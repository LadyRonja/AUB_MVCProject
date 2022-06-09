using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using WebProject.Data;
using WebProject.Models;

namespace WebProject.Controllers
{
    [Authorize]
    public class PeopleController : Controller
    {
        private static PeopleViewModel viewModel;
        private readonly ApplicationDbContext _context;

        public PeopleController(ApplicationDbContext context)
        {
            _context = context;

            // Ensure viewmodel existance
            if (viewModel == null)
            {
                viewModel = new PeopleViewModel();
                viewModel.AllPeople = _context.People.ToList();

                // Update viewmodel persons with additional city information
                for (int i = 0; i < viewModel.AllPeople.Count; i++)
                {
                    viewModel.AllPeople[i].City = _context.Cities.Find(viewModel.AllPeople[i].CityID);
                }

                UpdateViewmodelLangauges();
            }
        }

        public IActionResult Index()
        {
            // Update viewmodel information
            viewModel.AllPeople = _context.People.ToList();
            for (int i = 0; i < viewModel.AllPeople.Count; i++)
            {
                viewModel.AllPeople[i].City = _context.Cities.Find(viewModel.AllPeople[i].CityID);
            }

            UpdateViewmodelLangauges();

            // Settings dropdown list option for cities
            ViewBag.Cities = new SelectList(_context.Cities.ToList(), "ID", "Name");

            return View("PeopleTable", viewModel);
        }

        public IActionResult PersonEditor(Guid personID)
        {
            Person personToEdit = viewModel.AllPeople.First(p => p.ID == personID);

            // Settings dropdown list option for cities
            ViewBag.Cities = new SelectList(_context.Cities.ToList(), "ID", "Name");

            return View(personToEdit);
        }

        [HttpPost]
        public IActionResult EditPerson(Person model)
        {
            if (ModelState.IsValid)
            {
                Person personToUpdate = _context.People.Find(model.ID);
                personToUpdate.Name = model.Name;
                personToUpdate.CityID = model.CityID;
                personToUpdate.PhoneNumber = model.PhoneNumber;

                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Search(PeopleViewModel model)
        {
            viewModel.Filter = model.Filter;
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CreatePerson(PeopleViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Verify that the city ID is valid and exists
                if (Guid.TryParse(model.PersonFactory.CityID, out var id))
                {
                    if (_context.Cities.Find(id) != null)
                    {
                        model.PersonFactory.AddPersonToDataBase(_context);
                    }
                }
            }
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult RemovePerson(Guid personID)
        {
            var personToRemove = _context.People.Find(personID);

            _context.People.Remove(personToRemove);
            _context.SaveChanges();


            return RedirectToAction("Index");
        }

        private void UpdateViewmodelLangauges()
        {
            // For each person, get all languages they speak
            for (int p = 0; p < viewModel.AllPeople.Count; p++)
            {
                List<LanguagePerson> languages = _context.LanguageSpeakers.Where(l => l.PersonID == viewModel.AllPeople[p].ID).ToList();

                // Find the language instance corresponding with the language ID,
                // Conenct it to the languagePerson then add the instance
                for (int l = 0; l < languages.Count; l++)
                {
                    languages[l].Language = _context.Languages.Find(languages[l].LanguageID);
                }

                viewModel.AllPeople[p].Languages = new List<LanguagePerson>(languages);
            }
        }
    }
}

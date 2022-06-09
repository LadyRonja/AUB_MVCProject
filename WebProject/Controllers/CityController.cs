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

    [Authorize(Roles = "Admin")]
    public class CityController : Controller
    {

        private static CitiesViewModel viewModel;
        private readonly ApplicationDbContext _context;

        public CityController(ApplicationDbContext context)
        {
            _context = context;

            // Ensure viewmodel existance
            if (viewModel == null)
            {
                viewModel = new CitiesViewModel();
                viewModel.AllCities = _context.Cities.ToList();

                // Update viewmodel cities with additional country information
                for (int i = 0; i < viewModel.AllCities.Count; i++)
                {
                    viewModel.AllCities[i].Country = _context.Countries.Find(viewModel.AllCities[i].CountryID);
                }
            }
        }

        public IActionResult Index()
        {
            // Update viewmodel cities with additional country information
            viewModel.AllCities = _context.Cities.ToList();
            for (int i = 0; i < viewModel.AllCities.Count; i++)
            {
                viewModel.AllCities[i].Country = _context.Countries.Find(viewModel.AllCities[i].CountryID);
            }

            // Settings dropdown list option for countries
            ViewBag.Countries = new SelectList(_context.Countries.ToList(), "ID", "Name");

            return View("CitiesTable", viewModel);
        }

        public IActionResult CityEditor(Guid cityID)
        {
            City cityToEdit = viewModel.AllCities.First(c => c.ID == cityID);

            // Settings dropdown list option for cities
            ViewBag.Countries = new SelectList(_context.Countries.ToList(), "ID", "Name");

            return View(cityToEdit);
        }

        [HttpPost]
        public IActionResult EditCity(City model)
        {
            if (ModelState.IsValid)
            {
                City cityToEdit = _context.Cities.Find(model.ID);
                cityToEdit.Name = model.Name;
                cityToEdit.CountryID = model.CountryID;

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
        public IActionResult CreateCity(CitiesViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Verify that the city ID is valid and exists
                if (Guid.TryParse(model.CityFactory.CountryID, out var id))
                {
                    if (_context.Countries.Find(id) != null)
                    {
                        model.CityFactory.AddCityToDataBase(_context);
                    }
                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoveCity(Guid cityID)
        {
            var cityToRemove = _context.Cities.Find(cityID);

            _context.Cities.Remove(cityToRemove);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}

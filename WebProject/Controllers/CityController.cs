﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebProject.Data;
using WebProject.Models;

namespace WebProject.Controllers
{
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

            return View("CitiesTable", viewModel);
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

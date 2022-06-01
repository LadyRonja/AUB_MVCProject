using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Data;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class CountryController : Controller
    {

        private static CountriesViewModel viewModel;
        private readonly ApplicationDbContext _context;

        public CountryController(ApplicationDbContext context)
        {
            _context = context;

            // Ensure viewmodel existance
            if (viewModel == null)
            {
                viewModel = new CountriesViewModel();
                viewModel.AllCountries = _context.Countries.ToList();

                // Update viewmodel cities with additional country information
                // Go through all cities and check what country they match with
                List<City> cities = _context.Cities.ToList();
                for (int i = 0; i < cities.Count; i++)
                {
                    for (int j = 0; j < viewModel.AllCountries.Count; j++)
                    {
                        if (cities[i].CountryID == viewModel.AllCountries[j].ID)
                        {
                            if (!viewModel.AllCountries[j].Cities.Contains(cities[i]))
                            {
                                viewModel.AllCountries[j].Cities.Add(cities[i]);
                            }
                            break;
                        }
                    }
                }
            }
        }
        public IActionResult Index()
        {
            viewModel.AllCountries = _context.Countries.ToList();

            // Go through all cities and check what country they match with
            List<City> cities = _context.Cities.ToList();
            for (int i = 0; i < cities.Count; i++)
            {
                for (int j = 0; j < viewModel.AllCountries.Count; j++)
                {
                    if (cities[i].CountryID == viewModel.AllCountries[j].ID)
                    {
                        if (!viewModel.AllCountries[j].Cities.Contains(cities[i]))
                        {
                            viewModel.AllCountries[j].Cities.Add(cities[i]);
                        }
                        break;
                    }
                }
            }

            return View("Countriestable", viewModel);
        }

        [HttpPost]
        public IActionResult Search(PeopleViewModel model)
        {
            viewModel.Filter = model.Filter;
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CreateCountry(CountriesViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.CountryFactory.AddCountryToDatabase(_context);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoveCountry(Guid countryID)
        {
            var cityToRemove = _context.Countries.Find(countryID);

            _context.Countries.Remove(cityToRemove);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}

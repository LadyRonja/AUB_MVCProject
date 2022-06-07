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

                UpdateViewmodelCities();
            }
        }
        public IActionResult Index()
        {
            viewModel.AllCountries = _context.Countries.ToList();

            UpdateViewmodelCities();

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
            var countryToRemove = _context.Countries.Find(countryID);

            _context.Countries.Remove(countryToRemove);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        private void UpdateViewmodelCities()
        {
            // For each country, get all its cities
            for (int i = 0; i < viewModel.AllCountries.Count; i++)
            {
                List<City> cities = _context.Cities.Where(ci => ci.CountryID == viewModel.AllCountries[i].ID).ToList();

                viewModel.AllCountries[i].Cities = new List<City>(cities);
            }
        }
    }
}

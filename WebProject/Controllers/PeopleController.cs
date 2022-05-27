using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WebProject.Data;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class PeopleController : Controller
    {
        private static PeopleViewModel viewModel;
        private readonly ApplicationDbContext _context;

        public PeopleController(ApplicationDbContext context)
        {
            _context = context;
            if (viewModel == null)
            {
                viewModel = new PeopleViewModel();
                viewModel.AllPeople = _context.People.ToList();
            }
        }

        public IActionResult Index()
        {
            viewModel.AllPeople = _context.People.ToList();
            return View("PeopleTable", viewModel);
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
                model.PersonFactory.AddPersonToDataBase(_context);
            }
            return RedirectToAction("Index");
        }


        public IActionResult RemovePerson(Guid personID)
        {
            var personToRemove = _context.People.Find(personID);

            _context.People.Remove(personToRemove);
            _context.SaveChanges();


            return RedirectToAction("Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Data;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class LanguageController : Controller
    {
        private static LanguagesViewModel viewModel;
        private readonly ApplicationDbContext _context;

        public LanguageController(ApplicationDbContext context)
        {
            _context = context;

            // Ensure viewmodel existance
            if (viewModel == null)
            {
                viewModel = new LanguagesViewModel();
                viewModel.AllLanguage = _context.Languages.ToList();
            }
        }

        public IActionResult Index()
        {
            // Update viewmodel information
            viewModel.AllLanguage = _context.Languages.ToList();
            UpdateViewModelSpeakers();

            return View("LanguagesTable", viewModel);
        }

        [HttpPost]
        public IActionResult CreateLanguage(LanguagesViewModel model)
        {
            if (model.LanguageFactory.Name != null)
            {
                model.LanguageFactory.AddLanguageToDatabase(_context);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ConnectSpeakerAndLanguage(LanguagesViewModel model)
        {
            if (model.Connector.PersonID != null && model.Connector.LanguageID != null)
            {
                // Verify that the Person and Language exists
                if (Guid.TryParse(model.Connector.PersonID, out var p) && Guid.TryParse(model.Connector.LanguageID, out var l))
                {
                    if (_context.People.Find(p) != null && _context.Languages.Find(l) != null)
                    {
                        model.Connector.ConnectPersonAndLanguage(_context);
                    }
                }
            }
            return RedirectToAction("Index");
        }


        public IActionResult RemoveLanguage(Guid languageID)
        {
            var languageToRemove = _context.Languages.Find(languageID);

            _context.Languages.Remove(languageToRemove);
            _context.SaveChanges();


            return RedirectToAction("Index");
        }

        private void UpdateViewModelSpeakers()
        {
            // For each speaker, get all people who speak that language
            for (int l = 0; l < viewModel.AllLanguage.Count; l++)
            {
                List<LanguagePerson> speakers = _context.LanguageSpeakers.Where(s => s.LanguageID == viewModel.AllLanguage[l].ID).ToList();

                // Find the person instance corresponding with the speaker,
                // Conenct it to the speaker then add the speaker to the language list
                for (int s = 0; s < speakers.Count; s++)
                {
                    speakers[s].Speaker = _context.People.Find(speakers[s].PersonID);
                }

                viewModel.AllLanguage[l].Speakers = new List<LanguagePerson>(speakers);
            }
        }
    }
}

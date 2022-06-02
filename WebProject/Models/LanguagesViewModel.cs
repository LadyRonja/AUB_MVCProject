using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class LanguagesViewModel
    {
        public LanguageFactory LanguageFactory { get; set; }
        public LanguagePersonConnector Connector { get; set; }
        public List<Language> AllLanguage { get; set; }

        public LanguagesViewModel()
        {
            LanguageFactory = new LanguageFactory();
            Connector = new LanguagePersonConnector();
        }
    }
}

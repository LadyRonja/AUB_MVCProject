using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Data;

namespace WebProject.Models
{
    public class LanguagePersonConnector
    {
        [Required]
        public string PersonID { get; set; }

        [Required]
        public string LanguageID { get; set; }

        public void ConnectPersonAndLanguage(ApplicationDbContext context)
        {
            LanguagePerson connection = new LanguagePerson
            {
                PersonID = Guid.Parse(this.PersonID),
                LanguageID = Guid.Parse(this.LanguageID)
            };

            context.LanguageSpeakers.Add(connection);
            context.SaveChanges();
        }
    }
}

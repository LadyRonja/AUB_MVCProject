using System;
using System.ComponentModel.DataAnnotations;
using WebProject.Data;

namespace WebProject.Models
{
    public class LanguageFactory
    {
        [Required]
        public string Name { get; set; }

        public void AddLanguageToDatabase(ApplicationDbContext context)
        {
            Language languageToAdd = new Language
            {
                Name = this.Name,
                ID = Guid.NewGuid()
            };

            context.Languages.Add(languageToAdd);
            context.SaveChanges();
        }
    }
}

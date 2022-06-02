using System;
using System.ComponentModel.DataAnnotations;

namespace WebProject.Models
{
    public class LanguagePerson
    {
        [Required]
        public Guid LanguageID { get; set; }
        public Language Language { get; set; }

        [Required]
        public Guid PersonID { get; set; }
        public Person Speaker { get; set; }
    }
}

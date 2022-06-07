using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class Language
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public string Name { get; set; }

        public List<LanguagePerson> Speakers {get;set;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class CountriesViewModel
    {
        public CountryFactory CountryFactory { get; set; }
        public List<Country> AllCountries { get; set; }
        public string Filter { get; set; }

        public CountriesViewModel()
        {
            CountryFactory = new CountryFactory();
        }
    }
}

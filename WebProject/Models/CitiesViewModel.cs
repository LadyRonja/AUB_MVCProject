using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class CitiesViewModel
    {
        public CityFactory CityFactory { get; set; }
        public List<City> AllCities { get; set; }
        public string Filter { get; set; }

        public CitiesViewModel()
        {
            CityFactory = new CityFactory();
        }
    }
}

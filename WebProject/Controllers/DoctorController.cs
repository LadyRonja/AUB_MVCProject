using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class DoctorController : Controller
    {
        [Route("FeverCheck")]
        public IActionResult FeverCheck()
        {
            return View();
        }

        [HttpPost]
        [Route("FeverCheck")]
        public IActionResult FeverCheck(string temperature)
        {
            float input;

            if (float.TryParse(temperature, out input))
            {
                if (Doctor.CheckFever(input))
                {

                    ViewBag.Temperature = "You have a fever!";
                }
                else
                {
                    ViewBag.Temperature = "You do not have a fever!";
                }
                
            }

            return View();
        }
    }
}


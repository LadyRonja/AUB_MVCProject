using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class AjaxController : Controller
    {
        // Use reference to viewmodel as backend/database
        public static PeopleViewModel database = new PeopleViewModel();

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult GetPeople()
        {
            return PartialView("_PersonList", database.AllPeople);
        }

        public ActionResult GetDetails(string index)
        {
            int inputToInt = -1;
            if (int.TryParse(index, out inputToInt))
            {
                if (inputToInt < database.AllPeople.Count)
                {
                    return PartialView("_PersonDetails", database.AllPeople[inputToInt]);
                }
            }

            return PartialView("_PersonList", database.AllPeople);
        }

        public ActionResult RemovePerson(string index)
        {
            int inputToInt = -1;
            if (int.TryParse(index, out inputToInt))
            {
                if (inputToInt < database.AllPeople.Count)
                {
                    database.AllPeople.RemoveAt(inputToInt);
                }
            }

            return PartialView("_PersonList", database.AllPeople);
        }

        /*[HttpPost]
        public IActionResult jsonexample()
        {
            return Json( new { Message = "test" }, new Newtonsoft.Json.JsonSerializerSettings());
        }*/

        //public IActionResult JSON(string model)
        //{
        //    JavaScriptSerializer serializer = new JavaScriptSerializer();
        //    var fromJSON = serializer.Deserialize<JSONModel>(model);
        //    return Json(fromJSON);
        //}
    }
}

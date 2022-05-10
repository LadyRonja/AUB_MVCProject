using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class GamesController : Controller
    {
        [Route("GuessingGame")]
        public IActionResult GuessingGame()
        {
            // Randomize a number on initial page load and store in the session
            int randomized = new Random().Next(1, 101);
            HttpContext.Session.SetInt32("CorrectNumber", randomized);


            return View();
        }

        [HttpPost]
        [Route("GuessingGame")]
        public IActionResult GuessingGame(int guess)
        {
            // Static GuessResult function returns message regarding game and weather or not the game is over
            bool gameOver = false;
            ViewBag.Results = GuessingGameLogic.GuessResult(guess, (int)HttpContext.Session.GetInt32("CorrectNumber"), out gameOver);
            ViewBag.GameIsOver = gameOver;

            return View();
        }
    }
}



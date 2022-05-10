using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class GuessingGameLogic
    {
        public static string GuessResult(int guess, int correctAwnser, out bool gameOver)
        {

            gameOver = (guess == correctAwnser);

            if (guess > correctAwnser)
            {
                return $"No, it's lower than {guess}";
            }

            if (guess < correctAwnser)
            {
                return $"No, it's higher than {guess}";
            }

            if (guess == correctAwnser)
            {
                return $"That's right, you win! Play again?";
            }

            return "An error has occured, please contact the staff.";
        }
    }
}

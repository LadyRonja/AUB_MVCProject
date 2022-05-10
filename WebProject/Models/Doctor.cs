using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class Doctor
    {
        private static readonly float feverThreshold = 38.0f;

        /// <summary>
        /// Returns true if the temperature is 38 or higher
        /// </summary>
        /// <returns></returns>
        public static bool CheckFever(float temperature)
        {
            return (temperature >= feverThreshold);
        }
    }
}

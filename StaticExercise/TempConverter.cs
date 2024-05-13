using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {

        public static double FaherenheitToCelius(double numOne)
        {
            return (numOne - 32) * 5/9;

        }

        public static double CeliusToFahernheit(double numOne)
        {
            return (numOne * 9/5) + 32;

        }
    }
}

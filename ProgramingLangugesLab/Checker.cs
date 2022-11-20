using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingLangugesLab
{
    public static class Checker
    {
        public static bool IsPositiveNumber(double value)
        {
            if (value >= 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Number is mines.");
                return false;
            }
        }
        public static bool Is0To100(double value)
        {
            if (value >= 0 && value <= 100)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Number must be between 0 to 100");
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingLangugesLab
{
    public static class Converter
    {
        public static void ConvertCToF()
        {
            Console.WriteLine("Enter centigrade:");
            double centigrade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"In farenhight is:{centigrade * 1.8 + 32}");
        }

        public static void GetAbsOfArray()
        {
            Console.WriteLine("Enter how many number do you have?");
            double n = Convert.ToDouble(Console.ReadLine());
            while (!Checker.IsPositiveNumber(n))
            {
                n = Convert.ToDouble(Console.ReadLine());
            }

            List<double> numberList = new List<double>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("enter the " + i + "th number:");
                double absResult = Math.Abs(Convert.ToDouble(Console.ReadLine()));
                numberList.Add(absResult);
            }
            Console.WriteLine("all abs result:");
            foreach (var d in numberList)
            {
                Console.WriteLine(d);
            }
        }

    }
}

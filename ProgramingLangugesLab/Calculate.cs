using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingLangugesLab
{
    public static class Calculate
    {
        public static void CalculateMasahat()
        {
            Console.WriteLine("enter a height:");
            double height = Convert.ToDouble(Console.ReadLine());
            while (!Checker.IsPositiveNumber(height))
            {
                height = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("enter a ghaede:");
            double ghaede = Convert.ToDouble(Console.ReadLine());
            while (!Checker.IsPositiveNumber(height))
            {
                ghaede = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Masahat is equal to " + (ghaede * height) / 2);
        }
        public static void YaranehCal()
        {
            Console.WriteLine("Number of family member:");
            int familyLenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your yaraneh is equle to " + 45000 * familyLenght);
        }
        public static void StudentScore()
        {
            List<Student> studentList = new List<Student>();
            bool skipAddingNewStudent = false;
            while (!skipAddingNewStudent)
            {
                Student newStudent = new Student();

                Console.WriteLine("Student Name:");
                newStudent.Name = Console.ReadLine();
                Console.WriteLine("that quiz score:");
                newStudent.Quiz = Convert.ToDouble(Console.ReadLine());
                while (!Checker.Is0To100(newStudent.Quiz))
                {
                    newStudent.Quiz = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("Write that transactional score:");
                newStudent.Transactional = Convert.ToDouble(Console.ReadLine());
                while (!Checker.Is0To100(newStudent.Transactional))
                {
                    newStudent.Transactional = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("Write that homework score:");
                newStudent.Homework = Convert.ToDouble(Console.ReadLine());
                while (!Checker.Is0To100(newStudent.Homework))
                {
                    newStudent.Homework = Convert.ToDouble(Console.ReadLine());
                }
                studentList.Add(newStudent);
                Console.WriteLine("For adding new student push Y keyword. otherwise you will get scors.");
                if (Console.ReadLine() != "Y")
                {
                    skipAddingNewStudent = true;
                }
                else
                {
                    skipAddingNewStudent = false;
                }
            }

            foreach (var aStudent in studentList)
            {
                Console.WriteLine(aStudent.Name + " Score is: " + aStudent.EndScoore);
            }

        }
        public static void CalcuteMobileCredit()
        {

            double sumPrice = 3000;
            Console.WriteLine("Call count?");
            int callCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= callCount; i++)
            {
                Console.WriteLine($"Talk number {i} duration by sec:");
                int secondsCall = Convert.ToInt32(Console.ReadLine());
                if (secondsCall > 0 && secondsCall <= 60)
                {
                    sumPrice += secondsCall * 10;
                }
                else if (secondsCall <= 150 && secondsCall > 60)
                {
                    sumPrice += secondsCall * 15;
                }
                else
                {
                    sumPrice += secondsCall * 20;
                }
            }
            Console.WriteLine("With internt? Y");
            if (Console.ReadLine() == "Y")
            {
                sumPrice += 7000;
            }
            Console.WriteLine("Cost: \n    " + sumPrice);
        }
        public static void TaxCalcute()
        {
            int maliatPercentage = 3;
            Console.WriteLine("Net income:");
            int salary = int.Parse(Console.ReadLine());
            int salaryAfterMaliat = salary - ((maliatPercentage * salary) / 100);
            Console.WriteLine("Your salary is: " +
                              salaryAfterMaliat);
        }
        public static void CalcutelightSpeed()
        {
            int distanceShayan = 300;
            double lightYearKm = 9460800000000;
            double hoursToSee = ((distanceShayan * lightYearKm) / (300000 * 3600));
            Console.WriteLine($"{hoursToSee} hour we need to wait.");
        }
    }
}

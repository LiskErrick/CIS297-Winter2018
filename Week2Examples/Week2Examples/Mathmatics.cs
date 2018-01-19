using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Examples
{
    public class Mathmatics
    {

        private int _runningTotal;
        private float someFloatingNumber = 0.0f;

        public Mathmatics()
        {
            _runningTotal = 0;
            Console.Write("5 / 2 = ");
            Console.Write(5.0 / 2);
            Console.WriteLine();
            Console.WriteLine("You made a new math!");

            int max = Int32.MaxValue;

            Console.WriteLine(max);
            max += 10;
            Console.WriteLine(max);



        }
        public int add(int first, int second)
        {
            // ++first adds 1 before it's used, second++ adds 1 after it's used
            var result = ++first + second++;
            _runningTotal += result;

            bool matches = first == second;

            // is equivelent to the if else block below
            result = matches ? first * 2 : first + second;

            // equivelent to the funny looking thing above
            if (matches)
            {
                result = first * 2;
            }
            else
            {
                result = first + second;
            }

            return result;
        }

        public double add(double first, double second = 0)
        {
            return 0.0;
        }

        public int difference(int first, int second)
        {
            return first < second ? second - first : first - second;
        }

        public double division( int first, int second)
        {
            return first / second;
        }

        public int getRunningTotal()
        {
            return _runningTotal;
        }

        public void AskForSalaryInfoAndDisplayWeeklyPay()
        {
            Console.Write("Please enter your hourly pay rate: ");
            var hourlyPay = Console.ReadLine();
            var hourlyPayAsDouble = Double.Parse(hourlyPay);

            Console.Write("Please enter the number of hours you work each week: ");
            var hoursWorked = Console.ReadLine();
            var hoursWorkedAsDouble = Double.Parse(hoursWorked);
            
            // escape character for quote marks
            Console.Write("\"WOW\" you make $");
            Console.Write(hourlyPayAsDouble * hoursWorkedAsDouble);
            Console.Write(" in a week!");

            Console.WriteLine("The tax man says that is too much!");
            Console.WriteLine($"After taxes you make: {hourlyPayAsDouble * hoursWorkedAsDouble * (8.0 / 9)}!");
        }
    }
}

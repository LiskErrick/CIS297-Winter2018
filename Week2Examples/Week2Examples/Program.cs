using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Examples
{
    class Program
    {
        
        public static int myFavoriteNumber, yourFavoriteNumber;

        public static string firstName = null;


        // defaults to private if you don't declare
        static int thirteen = 0b00001101;

        static int seventeen = 0x11;

        static int someBigValue = 123_456_789;

        static void Main(string[] args)
        {
            var areYouHungry = true;

            // don't try to do things with null objections
            Console.WriteLine(firstName.Length);

            Console.WriteLine("Hello World!");
            Console.WriteLine("Hi there Eric!");

            // write will not add a new line at the end
            Console.Write(myFavoriteNumber);

            // escape sequence for newline
            Console.Write("\n");

            // always print a new line regardless
            Console.WriteLine();

            Console.WriteLine(someBigValue);

            Console.Write("Next line please!");

            // calls the Mathmatics constructor method
            //var myMath = new Mathmatics();

            //Console.WriteLine(myMath.add(thirteen, seventeen));
            //Console.WriteLine(myMath.add(thirteen, seventeen));
            //Console.WriteLine(myMath.add(thirteen, seventeen));
            //Console.WriteLine(myMath.getRunningTotal());

            // read key will wait for any key press
            //Console.ReadKey();

            // use write to have prompt on the same line
            //Console.Write("Please enter your name: ");
            //_name = Console.ReadLine(); // will wait for the enter key

            //Console.WriteLine("Hi " + _name);

            //myMath.AskForSalaryInfoAndDisplayWeeklyPay();
            //printTriangle(10);

            Mathmatics math = new Mathmatics();

            // having a default value in a parameter makes it optional
            math.add(1.0, 2.0);
            math.add(1.0);

            // named parameters vs positional parameters
            math.add(second: 2.0, first: 1.0);

            ArrayExamples randomArray = new ArrayExamples();
            randomArray.printScores();

            Console.ReadKey();
        }

        public static void printTriangle(int size)
        {
            for ( int row = 0; row < size; row++ )
            {
                for ( int col = 0; col < row; col++ )
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // must be static if I want to assign it in the static main method
        private static String _name;
    }
}

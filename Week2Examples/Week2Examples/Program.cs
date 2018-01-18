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

        public string firstName;

      
        // defaults to private if you don't declare
        int thirteen = 0b00001101;

        int seventeen = 0x11;

        static int someBigValue = 123_456_789;

        static void Main(string[] args)
        {
            var areYouHungry = true;

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

            // read key will wait for any key press
            Console.ReadKey();

            //Console.ReadLine(); will wait for the enter key
        }

        private String _name;
    }
}

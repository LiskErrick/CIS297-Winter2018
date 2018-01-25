using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            int favorite_number;

            favorite_number = Int32.Parse(Console.ReadLine());

            var name;

            Console.WriteLine($"Hi {name}");

            var weather = string.Empty;
            int temp = 0;

            weather = temp > 32 ? "Rain" : "Snow";

            int[] arrayOfUnkonwnSize = new int[] { 1, 2, 3 };

            foreach ( int number in arrayOfUnkonwnSize )
            {
                Console.WriteLine(number);
            }

            for( int index = 0; index < arrayOfUnkonwnSize.Length ; index++ )
            {
                Console.WriteLine(arrayOfUnkonwnSize[index]);
            }

        }
    }
}

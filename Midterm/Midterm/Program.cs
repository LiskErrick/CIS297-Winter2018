using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 2, 3, 5, 7, 11 };
            var deliver = "Delivers";
            var toReverse = deliver.ToCharArray();
            Console.WriteLine(toReverse);
            Reverse(toReverse);
            Console.WriteLine(toReverse);
            Console.ReadLine();
        }

        public static void PrintStickFigure( char c = '*')
        {

        }

        public static void Reverse(char[] toReverse)
        {
            for( int index = 0; index < toReverse.Length / 2; index++ )
            {
                char temp = toReverse[index];
                toReverse[index] = toReverse[toReverse.Length - index - 1];
                toReverse[toReverse.Length - index - 1] = temp;
            }
        }
    }
}

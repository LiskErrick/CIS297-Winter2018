using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7
{
    public delegate int MathDelegate(int a, int b);
    public class Program
    {
        static void Main(string[] args)
        {
            //MathDelegate operation = Add;
            //Console.WriteLine(operation(1, 2));

            //operation = Multiply;
            //Console.WriteLine(operation(2, 3));

            LotteryPicker numbers = new LotteryPicker();
            numbers.ToggleConsoleLogging();
            var numberCount = 0;
            while (numberCount < 1000)
            {
                numbers.pickNumber();
                if ( numberCount == 200 )
                {
                    numbers.ToggleFileLogging();
                }
                numberCount++;
            }
          

            Console.ReadLine();
        }

        

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int first, int second)
        {
            return first * second;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week9
{
    public class Program
    {
        static void Main(string[] args)
        {
            //new Threads();

            Fib fib = new Fib();

            foreach( long f in fib)
            {
                Thread.Sleep(100);
                Console.WriteLine(f);
            }

            Console.ReadLine();
            //Environment.Exit(0);
        }
    }
}

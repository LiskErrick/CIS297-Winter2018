using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7
{
    public class ListsWIthLambdas
    {
        private List<int> numbers;
        public ListsWIthLambdas()
        {
            numbers = new List<int>();

            Random random = new Random();

            for ( int n = 0; n < 100; n++ )
            {
                numbers.Add(random.Next(1, 1000));
            }

        }

        public List<int> primes()
        {
            return numbers.Where(number => isPrime(number)).ToList();
        }

        public List<int> evens()
        {
            //List<int> results = new List<int>();

            //foreach( var number in numbers )
            //{
            //    if ( number % 2 == 0)
            //    {
            //        results.Add(number);
            //    }
            //}

            return numbers.Where(number => number % 2 == 0).ToList();
        }

        private bool isPrime(int number)
        {
            for( int divisor =2; divisor < Math.Ceiling(Math.Sqrt(number)); divisor ++)
            {
                if ( number % divisor == 0 )
                {
                    return false;
                }
            }
            return true;
        }
    }
}

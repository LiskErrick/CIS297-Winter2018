using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    // Q 38
    public class LuckyNumber : ILuckyNumber
    {
        public int GetLuckyNumber()
        {
            return 42;
        }
    }

    // Q 39
    public class RandomLuckyNumber : ILuckyNumber
    {
        // better to have a class level random instance
        private Random random;
        public RandomLuckyNumber()
        {
            random = new Random();
        }
        public int GetLuckyNumber()
        {
            return random.Next(1, 101);
        }
    }
}

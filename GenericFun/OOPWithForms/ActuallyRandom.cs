using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithForms
{
    public class ActuallyRandom : IRandom
    {
        private Random _random;

        public ActuallyRandom()
        {
            _random = new Random();
        }

        public int Next(int lowerBound, int upperBoud)
        {
            return _random.Next(lowerBound, upperBoud);
        }
    }
}

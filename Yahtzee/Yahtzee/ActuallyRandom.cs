using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Yahtzee
{
    public class ActuallyRandom : INumberGenerator
    {
        Random random;
        public ActuallyRandom()
        {
            random = new Random();
        }
        public int Next(int low, int high)
        {
            return random.Next(low, high);
            
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9
{
    public class Fib : IEnumerable<long>
    {
        private long previous;
        private long current;
        public Fib()
        {
            previous = 0;
            current = 1;
        }

        public IEnumerator<long> GetEnumerator()
        {
            while(true)
            {
                long next = previous + current;

                yield return current;
                previous = current;
                current = next;
            }
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

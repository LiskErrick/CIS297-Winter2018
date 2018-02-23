using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7
{
    public class Card
    {
        public Face Face { get; set; }
        public Suit Suit { get; set; }

        public override String ToString()
        {
            return $"{Face.ToString()} of {Suit.ToString()}";
        }
    }
}

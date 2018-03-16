using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card
    {
        public Face Face { get; set; }
        public Suit Suit { get; set; }

        public int Points()
        {
            List<Face> faces = new List<Face> { Face.Ten, Face.Jack, Face.Queen, Face.King };
            if (faces.Contains(Face))
            {
                return 10;
            }
            else if (Face == Face.Ace)
            {
                return 11;
            }
            else
            {
                return (int)Face;
            }
        }

        public override String ToString()
        {
            return $"{Face.ToString()} of {Suit.ToString()}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7
{
    public class Deck
    {
        private List<Card> cards;
        private Random random;

        public Deck()
        {
            random = new Random();

            cards = new List<Card>();

            for (int deck = 0; deck < 6; deck++)
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    foreach (Face face in Enum.GetValues(typeof(Face)))
                    {
                        cards.Add(new Card { Face = face, Suit = suit });
                    }
                }
            }
        }

        public bool IsEmpty()
        {
            return !cards.Any();
        }

        public List<Card> Hearts()
        {
            var results = from card in cards
                          where (card.Face == Face.Ten
                          ||card.Face == Face.Jack 
                          || card.Face == Face.Queen 
                          || card.Face == Face.King )
                          //orderby card.Face, card.Suit - this is more interesting if you don't have just hearts
                          select card;

            // get some string representations out
            //var results = from card in cards
            //              let value = (int)card.Face
            //              where card.Suit == Suit.Hearts
            //              select $"{card}'s value is: {value + 2}";

            return results.ToList();
        }

        public Card DrawCard()
        {
            if ( !cards.Any() )
            {
                throw new InvalidOperationException("Deck is empty!");
            }
            var index = random.Next(0, cards.Count);
            var card = cards[index];
            cards.RemoveAt(index);
            return card;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach( var card in cards )
            {
                builder.AppendLine(card.ToString());
            }
            return builder.ToString();
        }
    }
}

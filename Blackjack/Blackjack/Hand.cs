using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Hand
    {
        public List<Card> Cards { get; set; }
        public Player Player { get; private set; }
        public int Bet { get; set; }
        public bool Busted { get; set; }

        

        public Hand(Deck deck, Player player, int bet)
        {
            Player = player;
            Bet = bet;
            Busted = false;
            Cards = new List<Card>
            {
                deck.DrawCard(),
                deck.DrawCard()
            };
        }

        public int GetPointValue()
        {
            var points = 0;
            foreach( var card in Cards )
            {
                points += card.Points();
            }
            // TODO - Fix if multiple aces
            if ( points > 21 && Cards.Any(c => c.Face == Face.Ace ))
            {
                points -= 10;
            }

            return points;
        }

        public override string ToString()
        {
            // string builder is better, this is lazy

            var result = "";
            foreach ( var card in Cards )
            {
                result += card.ToString() + Environment.NewLine;
            }

            result += $"Points: {GetPointValue()}";

            return result;
        }

        public bool CanSplit()
        {
            return Cards.Count == 2 && Cards[0].Face == Cards[1].Face;
        }
    }
}

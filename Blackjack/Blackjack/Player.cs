using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Player
    {
        public int Money { get; set; }
        public List<Hand> Hands { get; set; }

        public Player()
        {
            Money = 100;
            Hands = new List<Hand>();
        }

        public void Bet(int bet, Deck deck)
        {
            Hands.Add(new Hand(deck, this, bet));
        }
    }
}

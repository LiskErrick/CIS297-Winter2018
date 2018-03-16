using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        private List<Player> _players;
        private Player _dealer;
        private Deck _deck;

        private Player _activePlayer;
        public Form1()
        {
            InitializeComponent();
            _deck = new Deck();
            _players = new List<Player>();
            _dealer = new Player();



            _players.Add(new Player());

            _activePlayer = _players.First();

            foreach( var player in _players )
            {
                // just betting 5 start, we can change this later
                player.Bet( 5, _deck);
            }

            _dealer.Bet(0, _deck);
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            //                          gets the first hand, first card
            dealerLabel.Text = _dealer.Hands.First().Cards.First().ToString();


            // TODO - come back later and do 1 hand at a time
            playerLabel.Text = _activePlayer.Hands.First().ToString();
        }


    }
}

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

        private int currentPlayerIndex;

        private Player _activePlayer;
        public Form1()
        {
            InitializeComponent();
            _deck = new Deck();
            _players = new List<Player>();
            _dealer = new Player();

            currentPlayerIndex = 0;

            _players.Add(new Player());

            NextRound();

            UpdateLabels();
        }

        private void UpdateLabels()
        {
            //                          gets the first hand, first card
            dealerLabel.Text = _dealer.Hands.First().Cards.First().ToString();


            // TODO - come back later and do 1 hand at a time
            playerLabel.Text = _activePlayer.Hands.First().ToString();
            playerLabel.Text += Environment.NewLine + "Munny: $" + _activePlayer.Money.ToString();
        }

        private void playerStandButton_Click(object sender, EventArgs e)
        {
            currentPlayerIndex += 1;
            if ( currentPlayerIndex < _players.Count )
            {
                _activePlayer = _players[currentPlayerIndex];
                UpdateLabels();
            }
            else
            {
                DealerTurn();
            }
        }

        private void DealerTurn()
        {
            while ( _dealer.Hands.First().GetPointValue() <= 16 )
            {
                _dealer.Hands.First().Hit();
            }
            dealerLabel.Text = _dealer.Hands.First().ToString();
            foreach ( var player in _players )
            {
                if (!player.Hands.First().Busted && ( _dealer.Hands.First().Busted || 
                    ( player.Hands.First().GetPointValue() > _dealer.Hands.First().GetPointValue() ) ) )
                {

                    player.Money += player.Hands.First().Bet;
                    if ( player.Hands.First().GetPointValue() == 21 )
                    {
                        player.Money += (int)(player.Hands.First().Bet * .5);
                    }
                }
            }
            NextRound();

        }

        private void NextRound()
        {
            currentPlayerIndex = 0;
            _activePlayer = _players[currentPlayerIndex];

            foreach (var player in _players.Where(player => player.Money > 0) )
            {
                player.Hands.Clear();
                // just betting 5 start, we can change this later
                player.Bet(5, _deck);
            }

            _dealer.Bet(0, _deck);
            UpdateLabels();
        }
    }
}

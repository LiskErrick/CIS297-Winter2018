using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class Form1 : Form
    {
        YahtzeeScoreCard scoreCard;
        YahtzeeDice dice;

        public Form1()
        {
            InitializeComponent();
            dice = new YahtzeeDice();
            scoreCard = new YahtzeeScoreCard();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            dice.roll();
            die1.Text = dice.getDie1().ToString();
            die2.Text = dice.getDie2().ToString();
            die3.Text = dice.getDie3().ToString();
            die4.Text = dice.getDie4().ToString();
            die5.Text = dice.getDie5().ToString();

            var possibleScores = dice.getPossibleScores();

            if ( button1.Enabled )
            {
                onesScoreLabel.Text = possibleScores.Ones.ToString();
            }
            if (button2.Enabled)
            {
                twosScoreLabel.Text = possibleScores.Twos.ToString();
            }
            if (button3.Enabled)
            {
                threesScoreLabel.Text = possibleScores.Threes.ToString();
            }
            if (button4.Enabled)
            {
                foursScoreLabel.Text = possibleScores.Fours.ToString();
            }
            if (button5.Enabled)
            {
                fivesScoreLabel.Text = possibleScores.Fives.ToString();
            }
            if (button6.Enabled)
            {
                sixesScoreLabel.Text = possibleScores.Sixes.ToString();
            }

            if (dice.RollCount == 3)
            {
                rollButton.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scoreCard.Ones = dice.getPossibleScores().Ones;
            button1.Enabled = false;
            reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scoreCard.Twos = dice.getPossibleScores().Twos;
            button2.Enabled = false;
            reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            scoreCard.Threes = dice.getPossibleScores().Threes;
            button3.Enabled = false;
            reset();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            scoreCard.Fours = dice.getPossibleScores().Fours;
            button4.Enabled = false;
            reset();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            scoreCard.Fives = dice.getPossibleScores().Fives;
            button5.Enabled = false;
            reset();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            scoreCard.Sixes = dice.getPossibleScores().Sixes;
            button6.Enabled = false;
            reset();
        }

        private void reset()
        {
            rollButton.Enabled = true;
            dice = new YahtzeeDice();
            holdDie1.Checked = false;
            holdDie2.Checked = false;
            holdDie3.Checked = false;
            holdDie4.Checked = false;
            holdDie5.Checked = false;

            upperBonusLabel.Text = $"Upper Bonus: {scoreCard.UpperBonus()}";
        }

        private void holdDie1_CheckedChanged(object sender, EventArgs e)
        {
            dice.HoldDie1 = holdDie1.Checked;
        }

        private void holdDie2_CheckedChanged(object sender, EventArgs e)
        {
            dice.HoldDie2 = holdDie2.Checked;
        }

        private void holdDie3_CheckedChanged(object sender, EventArgs e)
        {
            dice.HoldDie3 = holdDie3.Checked;
        }

        private void holdDie4_CheckedChanged(object sender, EventArgs e)
        {
            dice.HoldDie4 = holdDie4.Checked;
        }

        private void holdDie5_CheckedChanged(object sender, EventArgs e)
        {
            dice.HoldDie5 = holdDie5.Checked;
        }
    }
}

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
            dice.DiceChanged += diceChangedHandler;
            scoreCard = new YahtzeeScoreCard();
        }

        private void diceChangedHandler(object sender, EventArgs e)
        {
            die1.Text = dice.getDie1().ToString();
            die2.Text = dice.getDie2().ToString();
            die3.Text = dice.getDie3().ToString();
            die4.Text = dice.getDie4().ToString();
            die5.Text = dice.getDie5().ToString();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            dice.roll();

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
            if(scoreThreeOfAKind.Enabled)
            {
                threeOfAKindLabel.Text = possibleScores.ThreeOfAKind.ToString();
            }
            if (scoreFourOfAKind.Enabled)
            {
                fourOfAKindLabel.Text = possibleScores.FourOfAKind.ToString();
            }
            if (scoreFullHouse.Enabled)
            {
                fullHouseLabel.Text = possibleScores.FullHouse.ToString();
            }
            if (scoreSmallStraight.Enabled)
            {
                smallStraightLabel.Text = possibleScores.SmallStraight.ToString();
            }
            if (scoreLargeStraight.Enabled)
            {
                largeStraightLabel.Text = possibleScores.LargeStraight.ToString();
            }
            if (scoreYahtzee.Enabled)
            {
                yahtzeeLabel.Text = possibleScores.Yahtzee.ToString();
            }
            if (scoreChance.Enabled)
            {
                chanceLabel.Text = possibleScores.Chance.ToString();
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
            dice.DiceChanged -= diceChangedHandler;
            dice = new YahtzeeDice();
            dice.DiceChanged += diceChangedHandler;
            holdDie1.Checked = false;
            holdDie2.Checked = false;
            holdDie3.Checked = false;
            holdDie4.Checked = false;
            holdDie5.Checked = false;

            die1.Text = string.Empty;
            die2.Text = string.Empty;
            die3.Text = string.Empty;
            die4.Text = string.Empty;
            die5.Text = string.Empty;

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

        private void scoreThreeOfAKind_Click(object sender, EventArgs e)
        {
            scoreCard.ThreeOfAKind = dice.getPossibleScores().ThreeOfAKind;
            scoreThreeOfAKind.Enabled = false;
            reset();
        }

        private void scoreFourOfAKind_Click(object sender, EventArgs e)
        {
            scoreCard.FourOfAKind = dice.getPossibleScores().FourOfAKind;
            scoreFourOfAKind.Enabled = false;
            reset();
        }

        private void scoreFullHouse_Click(object sender, EventArgs e)
        {
            scoreCard.FullHouse = dice.getPossibleScores().FullHouse;
            scoreFullHouse.Enabled = false;
            reset();
        }

        private void scoreSmallStraight_Click(object sender, EventArgs e)
        {
            scoreCard.SmallStraight = dice.getPossibleScores().SmallStraight;
            scoreSmallStraight.Enabled = false;
            reset();
        }

        private void scoreLargeStraight_Click(object sender, EventArgs e)
        {
            scoreCard.LargeStraight = dice.getPossibleScores().LargeStraight;
            scoreLargeStraight.Enabled = false;
            reset();
        }

        private void scoreYahtzee_Click(object sender, EventArgs e)
        {
            scoreCard.Yahtzee = dice.getPossibleScores().Yahtzee;
            scoreYahtzee.Enabled = false;
            reset();
        }

        private void scoreChance_Click(object sender, EventArgs e)
        {
            scoreCard.Chance = dice.getPossibleScores().Chance;
            scoreChance.Enabled = false;
            reset();
        }
    }
}

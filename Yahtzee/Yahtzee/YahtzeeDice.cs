using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class YahtzeeDice
    {
        private List<int> _dice;

        public int RollCount { get; set; }

        private INumberGenerator _numberGenerator;

        public bool HoldDie1 { get; set; } = false;
        public bool HoldDie2 { get; set; } = false;
        public bool HoldDie3 { get; set; } = false;
        public bool HoldDie4 { get; set; } = false;
        public bool HoldDie5 { get; set; } = false;

        public event EventHandler DiceChanged;

        public int this[int index]
        {
            get
            {
                return _dice[index];
            }
        }

        public YahtzeeDice() : this(new ActuallyRandom())
        {
            // empty
        }

        public YahtzeeDice(INumberGenerator numberGenerator)
        {
            _numberGenerator = numberGenerator;

            RollCount = 0;

            _dice = new List<int>() { 0, 0, 0, 0, 0 };
        }

        public void roll()
        {
            RollCount++;

            if (RollCount <= 3)
            {
                bool[] shouldHold = new bool[] { HoldDie1, HoldDie2, HoldDie3, HoldDie4, HoldDie5 }; 

                for( int index = 0; index < _dice.Count; index++ )
                {
                    if (!shouldHold[index])
                    {
                        _dice[index] = _numberGenerator.Next(low:1, high:7);
                    }
                }

                DiceChanged?.Invoke(this, EventArgs.Empty);

                // same as
                // if (DiceChanged != null)
                // {
                //    DiceChanged(this, EventArgs.Empty);
                // }
            }
        }

        private int sumOfDice()
        {
            var sum = 0;
            foreach( var die in _dice )
            {
                sum += die;
            }
            return sum;
        }

        public YahtzeeScoreCard getPossibleScores()
        {
            var scoreCard = new YahtzeeScoreCard();

            int[] upperScores = new int[6];
            List<int> numberOfTimeEachDieWasRolled = new List<int>() { 0, 0, 0, 0, 0, 0 };

            foreach( int die in _dice)
            {
                upperScores[die - 1] += die;
                numberOfTimeEachDieWasRolled[die - 1]++;
            }

            scoreCard.Ones = upperScores[0];
            scoreCard.Twos = upperScores[1];
            scoreCard.Threes = upperScores[2];
            scoreCard.Fours = upperScores[3];
            scoreCard.Fives = upperScores[4];
            scoreCard.Sixes = upperScores[5];

            if ( numberOfTimeEachDieWasRolled.Contains(5) )
            {
                scoreCard.Yahtzee = YahtzeeScoreCard.YAHTZEE;
            }

            if (numberOfTimeEachDieWasRolled.Contains(4))
            {
                scoreCard.FourOfAKind = sumOfDice();
                scoreCard.ThreeOfAKind = sumOfDice();
            }

            if (numberOfTimeEachDieWasRolled.Contains(3))
            {
                scoreCard.ThreeOfAKind = sumOfDice();
            }

            if (numberOfTimeEachDieWasRolled.Contains(3) 
                && numberOfTimeEachDieWasRolled.Contains(2))
            {
                scoreCard.FullHouse = YahtzeeScoreCard.FULL_HOUSE_SCORE;
            }

            if ( ( _dice.Contains(1) && _dice.Contains(2) && _dice.Contains(3) && _dice.Contains(4) )
                || ( _dice.Contains(2) && _dice.Contains(3) && _dice.Contains(4) && _dice.Contains(5) )
                || ( _dice.Contains(3) && _dice.Contains(4) && _dice.Contains(5) && _dice.Contains(6) )
                )
            {
                scoreCard.SmallStraight = YahtzeeScoreCard.SMALL_STRAIGHT_SCORE;
            }

            if ( ( _dice.Contains(1) && _dice.Contains(2) && _dice.Contains(3) && _dice.Contains(4) && _dice.Contains(5) )
                || (_dice.Contains(2) && _dice.Contains(3) && _dice.Contains(4) && _dice.Contains(5) && _dice.Contains(6) )
                )
            {
                scoreCard.LargeStraight = YahtzeeScoreCard.LARGE_STRAIGHT_SCORE;
            }

            scoreCard.Chance = sumOfDice();









            return scoreCard;
        }
    }
}

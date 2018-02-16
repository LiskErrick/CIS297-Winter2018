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

        private int _rollCount;

        private INumberGenerator _numberGenerator;

        public bool RollDie1 { get; set; } = true;
        public bool RollDie2 { get; set; } = true;
        public bool RollDie3 { get; set; } = true;
        public bool RollDie4 { get; set; } = true;
        public bool RollDie5 { get; set; } = true;

        public YahtzeeDice(INumberGenerator numberGenerator)
        {
            _numberGenerator = numberGenerator;

            _rollCount = 0;

            _dice = new List<int>() { 0, 0, 0, 0, 0 };
        }

        public void roll()
        {
            _rollCount++;

            if (_rollCount <= 3)
            {
                bool[] shouldRoll = new bool[] { RollDie1, RollDie2, RollDie3, RollDie4, RollDie5 }; 

                for( int index = 0; index < _dice.Count; index++ )
                {
                    if (shouldRoll[index])
                    {
                        _dice[index] = _numberGenerator.Next(1, 7);
                    }
                }
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
            }



            return scoreCard;
        }
    }
}

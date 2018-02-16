using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yahtzee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Tests
{
    [TestClass()]
    public class YahtzeeScoreCardTests
    {
        [TestMethod()]
        public void UpperBonusTest_GetsBonus()
        {
            YahtzeeScoreCard scoreCard = new YahtzeeScoreCard();
            scoreCard.Ones = 3;
            scoreCard.Twos = 6;
            scoreCard.Threes = 9;
            scoreCard.Fours = 12;
            scoreCard.Fives = 15;
            scoreCard.Sixes = 18;

            var expectedBonus = 35;

            Assert.AreEqual(expectedBonus, scoreCard.UpperBonus());
        }

        [TestMethod()]
        public void UpperBonusTest_DoesNotGetBonus()
        {
            YahtzeeScoreCard scoreCard = new YahtzeeScoreCard();
            scoreCard.Ones = 3;
            scoreCard.Twos = 6;
            scoreCard.Threes = 9;
            scoreCard.Fours = 12;
            scoreCard.Fives = 15;
            scoreCard.Sixes = 12;

            var expectedBonus = 0;

            Assert.AreEqual(expectedBonus, scoreCard.UpperBonus());
        }


    }
}
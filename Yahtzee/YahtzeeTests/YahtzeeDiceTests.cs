using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yahtzee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using YahtzeeTests;

namespace Yahtzee.Tests
{
    [TestClass()]
    public class YahtzeeDiceTests
    {
        // will come back to this

        //Mock<INumberGenerator> numberGenerator = new Mock<INumberGenerator>();
        //numberGenerator.Setup

        [TestMethod()]
        public void getPossibleScores_Yahtzee()
        {
            var expectedScore = 50;
            var numbers = new int[] { 1, 1, 1, 1, 1 };
            NotSoRandom notSoRandom = new NotSoRandom(numbers);
            YahtzeeDice dice = new YahtzeeDice(notSoRandom);
            dice.roll();
            var scores = dice.getPossibleScores();

            Assert.AreEqual(expectedScore, scores.Yahtzee);
        }

        [TestMethod()]
        public void getPossibleScores_LargeStraight()
        {
            var expectedScore = 40;
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            NotSoRandom notSoRandom = new NotSoRandom(numbers);
            YahtzeeDice dice = new YahtzeeDice(notSoRandom);
            dice.roll();
            var scores = dice.getPossibleScores();

            Assert.AreEqual(expectedScore, scores.LargeStraight);
        }

        [TestMethod()]
        public void getPossibleScores_SmallStraight()
        {
            var expectedScore = 30;
            var numbers = new int[] { 1, 2, 6, 4, 3 };
            NotSoRandom notSoRandom = new NotSoRandom(numbers);
            YahtzeeDice dice = new YahtzeeDice(notSoRandom);
            dice.roll();
            var scores = dice.getPossibleScores();

            Assert.AreEqual(expectedScore, scores.SmallStraight);
        }

        [TestMethod()]
        public void getPossibleScores_Chance()
        {
            var expectedScore = 16;
            var numbers = new int[] { 1, 2, 6, 4, 3 };
            NotSoRandom notSoRandom = new NotSoRandom(numbers);
            YahtzeeDice dice = new YahtzeeDice(notSoRandom);
            dice.roll();
            var scores = dice.getPossibleScores();

            Assert.AreEqual(expectedScore, scores.Chance);
        }

        [TestMethod()]
        public void getPossibleScores_FullHouse()
        {
            var expectedScore = 25;
            var numbers = new int[] { 1, 2, 1, 2, 1 };
            NotSoRandom notSoRandom = new NotSoRandom(numbers);
            YahtzeeDice dice = new YahtzeeDice(notSoRandom);
            dice.roll();
            var scores = dice.getPossibleScores();

            Assert.AreEqual(expectedScore, scores.FullHouse);
        }

        [TestMethod()]
        public void getPossibleScores_ThreeOfAKind()
        {
            var expectedScore = 7;
            var numbers = new int[] { 1, 2, 1, 2, 1 };
            NotSoRandom notSoRandom = new NotSoRandom(numbers);
            YahtzeeDice dice = new YahtzeeDice(notSoRandom);
            dice.roll();
            var scores = dice.getPossibleScores();

            Assert.AreEqual(expectedScore, scores.ThreeOfAKind);
        }

        [TestMethod()]
        public void getPossibleScores_FourOfAKind()
        {
            var expectedScore = 6;
            var numbers = new int[] { 1, 1, 1, 2, 1 };
            NotSoRandom notSoRandom = new NotSoRandom(numbers);
            YahtzeeDice dice = new YahtzeeDice(notSoRandom);
            dice.roll();
            var scores = dice.getPossibleScores();

            Assert.AreEqual(expectedScore, scores.FourOfAKind);
        }

        [TestMethod()]
        public void getPossibleScores_Ones()
        {
            var expectedScore = 4;
            var numbers = new int[] { 1, 1, 1, 2, 1 };
            NotSoRandom notSoRandom = new NotSoRandom(numbers);
            YahtzeeDice dice = new YahtzeeDice(notSoRandom);
            dice.roll();
            var scores = dice.getPossibleScores();

            Assert.AreEqual(expectedScore, scores.Ones);
        }

        [TestMethod()]
        public void getPossibleScores_Twos()
        {
            var expectedScore = 2;
            var numbers = new int[] { 1, 1, 1, 2, 1 };
            NotSoRandom notSoRandom = new NotSoRandom(numbers);
            YahtzeeDice dice = new YahtzeeDice(notSoRandom);
            dice.roll();
            var scores = dice.getPossibleScores();

            Assert.AreEqual(expectedScore, scores.Twos);
        }

        [TestMethod()]
        public void getPossibleScores_Threes()
        {
            var expectedScore = 6;
            var numbers = new int[] { 1, 1, 3, 3, 1 };
            NotSoRandom notSoRandom = new NotSoRandom(numbers);
            YahtzeeDice dice = new YahtzeeDice(notSoRandom);
            dice.roll();
            var scores = dice.getPossibleScores();

            Assert.AreEqual(expectedScore, scores.Threes);
        }

        [TestMethod()]
        public void getPossibleScores_Fours()
        {
            var expectedScore = 4;
            var numbers = new int[] { 1, 1, 4, 2, 1 };
            NotSoRandom notSoRandom = new NotSoRandom(numbers);
            YahtzeeDice dice = new YahtzeeDice(notSoRandom);
            dice.roll();
            var scores = dice.getPossibleScores();

            Assert.AreEqual(expectedScore, scores.Fours);
        }

        [TestMethod()]
        public void getPossibleScores_Fives()
        {
            var expectedScore = 20;
            var numbers = new int[] { 5, 5, 5, 5, 1 };
            NotSoRandom notSoRandom = new NotSoRandom(numbers);
            YahtzeeDice dice = new YahtzeeDice(notSoRandom);
            dice.roll();
            var scores = dice.getPossibleScores();

            Assert.AreEqual(expectedScore, scores.Fives);
        }

        [TestMethod()]
        public void getPossibleScores_Sixes()
        {
            var expectedScore = 0;
            var numbers = new int[] { 1, 1, 1, 2, 1 };
            NotSoRandom notSoRandom = new NotSoRandom(numbers);
            YahtzeeDice dice = new YahtzeeDice(notSoRandom);
            dice.roll();

            var scores = dice.getPossibleScores();

            Assert.AreEqual(expectedScore, scores.Sixes);
        }
    }
}
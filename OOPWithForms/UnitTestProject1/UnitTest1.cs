using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPWithForms;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Jackpot()
        {
            // Arrange
            var winningTicket = new PowerBallTicket(1, 2, 3, 4, 5, 6);
            var myTicket = new PowerBallTicket(5, 4, 3, 2, 1, 6);
            var expectedWinnings = 1000000000;

            // Act
            var actualWinnings = myTicket.getWinnings(winningTicket);

            // Assert
            Assert.AreEqual(expectedWinnings, actualWinnings);
        }

        [TestMethod]
        public void TestMethod_MatchFiveWhite()
        {
            // Arrange
            var winningTicket = new PowerBallTicket(1, 2, 3, 4, 5, 7);
            var myTicket = new PowerBallTicket(5, 4, 3, 2, 1, 6);
            var expectedWinnings = 1000000;

            // Act
            var actualWinnings = myTicket.getWinnings(winningTicket);

            // Assert
            Assert.AreEqual(expectedWinnings, actualWinnings);
        }

        [TestMethod]
        public void TestMethod_MatchFourWhiteAndRed()
        {
            // Arrange
            var winningTicket = new PowerBallTicket(1, 2, 3, 4, 6, 6);
            var myTicket = new PowerBallTicket(5, 4, 3, 2, 1, 6);
            var expectedWinnings = 50000;

            // Act
            var actualWinnings = myTicket.getWinnings(winningTicket);

            // Assert
            Assert.AreEqual(expectedWinnings, actualWinnings);
        }

        [TestMethod]
        public void TestMethod_MatchFourWhite()
        {
            // Arrange
            var winningTicket = new PowerBallTicket(1, 2, 3, 4, 6, 7);
            var myTicket = new PowerBallTicket(5, 4, 3, 2, 1, 6);
            var expectedWinnings = 100;

            // Act
            var actualWinnings = myTicket.getWinnings(winningTicket);

            // Assert
            Assert.AreEqual(expectedWinnings, actualWinnings);
        }

        [TestMethod]
        public void TestMethod_MatchThreeWhiteAndRed()
        {
            // Arrange
            var winningTicket = new PowerBallTicket(1, 2, 3, 7, 6, 6);
            var myTicket = new PowerBallTicket(5, 4, 3, 2, 1, 6);
            var expectedWinnings = 100;

            // Act
            var actualWinnings = myTicket.getWinnings(winningTicket);

            // Assert
            Assert.AreEqual(expectedWinnings, actualWinnings);
        }

        [TestMethod]
        public void TestMethod_MatchThreeWhite()
        {
            // Arrange
            var winningTicket = new PowerBallTicket(1, 2, 3, 7, 6, 7);
            var myTicket = new PowerBallTicket(5, 4, 3, 2, 1, 6);
            var expectedWinnings = 7;

            // Act
            var actualWinnings = myTicket.getWinnings(winningTicket);

            // Assert
            Assert.AreEqual(expectedWinnings, actualWinnings);
        }

        [TestMethod]
        public void TestMethod_MatchTwoWhiteAndRed()
        {
            // Arrange
            var winningTicket = new PowerBallTicket(1, 2, 8, 7, 6, 6);
            var myTicket = new PowerBallTicket(5, 4, 3, 2, 1, 6);
            var expectedWinnings = 7;

            // Act
            var actualWinnings = myTicket.getWinnings(winningTicket);

            // Assert
            Assert.AreEqual(expectedWinnings, actualWinnings);
        }


        [TestMethod]
        public void TestMethod_MatchOneWhiteAndRed()
        {
            // Arrange
            var winningTicket = new PowerBallTicket(5, 9, 8, 7, 6, 6);
            var myTicket = new PowerBallTicket(5, 4, 3, 2, 1, 6);
            var expectedWinnings = 4;

            // Act
            var actualWinnings = myTicket.getWinnings(winningTicket);

            // Assert
            Assert.AreEqual(expectedWinnings, actualWinnings);
        }
        [TestMethod]
        public void TestMethod_MatchRed()
        {
            // Arrange
            var winningTicket = new PowerBallTicket(10, 9, 8, 7, 6, 6);
            var myTicket = new PowerBallTicket(5, 4, 3, 2, 1, 6);
            var expectedWinnings = 4;

            // Act
            var actualWinnings = myTicket.getWinnings(winningTicket);

            // Assert
            Assert.AreEqual(expectedWinnings, actualWinnings);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestMethod_InvalidRed()
        {
            // Arrange
            var myTicket = new PowerBallTicket(5, 4, 3, 2, 1, 0);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestMethod_InvalidWhite()
        {
            // Arrange
            var myTicket = new PowerBallTicket(5, 4, 3, 2, 0, 1);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestMethod_DoubleWhite()
        {
            // Arrange
            var myTicket = new PowerBallTicket(5, 5,5,5,5,5);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestMethod_ArrayConstuctorThrows()
        {
            // Arrange
            var numbers = new int[] { 5, 5, 5, 5, 5, 5, 5 };
            var myTicket = new PowerBallTicket(numbers);
        }
    }
}

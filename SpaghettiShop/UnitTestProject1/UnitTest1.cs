using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// right, right click on the unit test project references and add reference
// find the solution section and check the project box
// add using for the namespace of the other project
using SpaghettiShop;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_CashRegister_ConstructorSetsTotalCost()
        {
            // Arrange
            CashRegister register = new CashRegister();
            double expectedTotalCost = 0;

            // Act

            // Assert
            Assert.AreEqual(register.TotalCost, expectedTotalCost);
        }

        [TestMethod]
        public void Test_CashRegister_AddSpaghetti()
        {
            // Arrange
            CashRegister register = new CashRegister();
            double expectedTotalCost = 3.0;

            // Act
            register.addItem("Spaghetti");

            // Assert
            Assert.AreEqual( expectedTotalCost, register.TotalCost);
        }

        [TestMethod]
        public void Test_CashRegister_GetChickenPrice()
        {
            // Arrange
            CashRegister register = new CashRegister();
            double expectedCostOfChicken = 1.0;

            // Act

            // Assert
            Assert.AreEqual(expectedCostOfChicken, register.GetPriceOf("Chicken"));

            // you can have multiple asserts
            Assert.AreEqual(5.0, register.GetPriceOf("Squid Ink"));
        }
    }
}

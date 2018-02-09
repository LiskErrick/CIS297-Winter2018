using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_IncomeOver500000()
        {
            // Arrange
            var grossIncome = 500000;
            var deductions = 15000;

            var expectedTaxesAt10Percent = 1865;
            var expectedTaxesAt15Percent = 8587.5;
            var expectedTaxesAt25Percent = (153100 - 75900) * .25;
            var expectedTaxesAt28Percent = (233350 - 153100) * .28;
            var expectedTaxesAt33Percent = (416700 - 233350) * .33;
            var expectedTaxesAt35Percent = (470700 - 416700) * .35;
            var expectedTaxesAt396Percent = ( grossIncome - deductions - 470700 ) * .396;

            var expectedTotalTaxes = expectedTaxesAt10Percent + expectedTaxesAt15Percent +
                expectedTaxesAt25Percent + expectedTaxesAt28Percent + expectedTaxesAt33Percent
                + expectedTaxesAt35Percent + expectedTaxesAt396Percent;

            var taxesAsPercentageOfGross = expectedTotalTaxes / grossIncome;
            var taxesAsPercentageOfAdjustedGross = expectedTotalTaxes / ( grossIncome - deductions );


            // Act
            var taxCalculator = new TaxCalculator(grossIncome, deductions);

            // Assert
            Assert.AreEqual(expectedTaxesAt10Percent, taxCalculator.TaxesAt10Percent);
            Assert.AreEqual(expectedTaxesAt15Percent, taxCalculator.TaxesAt15Percent);
            Assert.AreEqual(expectedTaxesAt25Percent, taxCalculator.TaxesAt25Percent);
            Assert.AreEqual(expectedTaxesAt28Percent, taxCalculator.TaxesAt28Percent);
            Assert.AreEqual(expectedTaxesAt33Percent, taxCalculator.TaxesAt33Percent);
            Assert.AreEqual(expectedTaxesAt35Percent, taxCalculator.TaxesAt35Percent);
            Assert.AreEqual(expectedTaxesAt396Percent, taxCalculator.TaxesAt396Percent);

            Assert.AreEqual(expectedTotalTaxes, taxCalculator.TotalTaxesOwed);

            Assert.AreEqual(taxesAsPercentageOfGross, taxCalculator.TaxesAsPercentageOfGrossIncome);
            Assert.AreEqual(taxesAsPercentageOfAdjustedGross, taxCalculator.TaxesAsPercentageOfAdustedGrossIncome);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week2Examples;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mathmatics math = new Mathmatics();
            int first = 10;
            int second = 20;
            int expectedResult = 31;

            int actualResult = math.add(first, second);

            Assert.AreEqual( expectedResult, actualResult);
        }

        [TestMethod]
        public void Test_Mathmatics_Quotient()
        {
            Mathmatics math = new Mathmatics();
            int first = 10;
            int second = 20;
            double expectedResult = 2.0;

            double actualResult = math.quotient(second, first);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Midterm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midterm;

namespace Midterm.Tests
{
    [TestClass()]
    public class ProgramTests
    {

        [TestMethod()]
        public void ReverseTest()
        {
            var deliver = "Delivers";
            var toReverse = deliver.ToCharArray();
            var expected = toReverse.Reverse().ToArray();

            var actual = deliver.ToCharArray();
            Program.Reverse(actual);

            Assert.AreEqual(new String(expected),  new String(actual));

        }
    }
}
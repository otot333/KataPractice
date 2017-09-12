using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataPractice.KataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPractice.KataClass.Tests
{
    [TestClass()]
    public class EvenOrOddTests
    {
        [TestMethod()]
        public void IsEvenOrOddsTest_Ifnumberis0_ThenThisisEven()
        {
            var number = 0;
            var EvenOdd = new EvenOrOdd();
            string expected = "Even";
            var actual = EvenOdd.IsEvenOrOdds(number);

            Assert.AreSame(expected, actual);
        }

        [TestMethod()]
        public void IsEvenOrOddsTest_Ifnumberis1_ThenThisisOdd()
        {
            var number = 1;
            var EvenOdd = new EvenOrOdd();
            string expected = "Odd";
            var actual = EvenOdd.IsEvenOrOdds(number);

            Assert.AreSame(expected, actual);
        }
    }
}
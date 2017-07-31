using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPractice.Tests
{
    [TestClass()]
    public class ArgeTests
    {
        private static void testing(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NbYearTest()
        {
            Console.WriteLine("Testing NbYear");
            testing(Arge.NbYear(1000, 2.0, 50, 1214), 4);
        }
    }
}
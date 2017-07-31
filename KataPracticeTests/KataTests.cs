﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPractice.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void GiveNumber_WhenNumberIs50_ThenReturnSun()
        {

            var expected = "It's hotter than the sun!!";

            //actual 
            var result = Kata.Apple(50);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void GiveNumber_WhenNumberIs3_ThenReturnHelp()
        {

            var expected = "Help yourself to a honeycomb Yorkie for the glovebox.";

            //actual 
            var result = Kata.Apple(3);

            Assert.AreEqual(expected, result);

        }

        [TestMethod()]
        public void GiveNumber_WhenNumberIsStr50_ThenReturnSun()
        {

            var expected = "It's hotter than the sun!!";

            //actual 
            var result = Kata.Apple("50");

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void GiveNumber_WhenNumberIsStr3_ThenReturnHelp()
        {

            var expected = "Help yourself to a honeycomb Yorkie for the glovebox.";

            //actual 
            var result = Kata.Apple("3");

            Assert.AreEqual(expected, result);

        }

        [TestMethod()]
        public void GiveNumber_WhenNumberIsStr0_ThenReturnHelp()
        {

            var expected = "Help yourself to a honeycomb Yorkie for the glovebox.";

            //actual 
            var result = Kata.Apple("0");

            Assert.AreEqual(expected, result);

        }

        [TestMethod()]
        public void GiveNumber_WhenNumberIsStr56_ThenReturnHelp()
        {

            var expected = "It's hotter than the sun!!";

            //actual 
            var result = Kata.Apple("34");

            Assert.AreEqual(expected, result);

        }

        private static string Solution(object n) => Int32.Parse(n.ToString()) > 31 ? "It's hotter than the sun!!" : "Help yourself to a honeycomb Yorkie for the glovebox.";

        [TestMethod()]
        public void RandomTest()
        {
            var rnd = new Random();
            for (int i = 0; i < 400; ++i)
            {

                object test;
                if (rnd.Next(0, 2) == 0)
                    test = rnd.Next(0, 61);
                else test =
                        rnd.Next(0, 61).ToString();
                string expected = Solution(test);
                string actual = Kata.Apple(test);
                Assert.AreEqual(expected, actual, $"{expected} , {actual} , {test}");
            }
        }

        [TestMethod()]
        public void FormatMoneyTest_WhenGive3_ThrnReturndollor3_00()
        {
            var dollor = 3;
            var expected = "$3.00";
            var actual = Kata.FormatMoney(dollor);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FormatMoneyTest_WhenGive3_1_ThrnReturndollor3_10()
        {
            var dollor = 3.1;
            var expected = "$3.10";
            var actual = Kata.FormatMoney(dollor);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FormatMoneyTest_WhenGive6638_46_ThrnReturndollor6_638_46()
        {
            var dollor = 6638.46;
            var expected = "$6,638.46";
            var actual = Kata.FormatMoney(dollor);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ParseFTest_GiveStr1_ThenReturn1_0d()
        {
            var str = "1";
            var expected = 1.0d;
            var actual = Kata.ParseF(str);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ParseFTest_GiveStr2_ThenReturn2_0d()
        {
            var str = "2";
            var expected = 2.0d;
            var actual = Kata.ParseF(str);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ParseFTest_GiveStr2_5_ThenReturn2_5d()
        {
            var str = "2.5";
            var expected = 2.5d;
            var actual = Kata.ParseF(str);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void ParseFTest_GiveStrNothing_ThenNull()
        {
            var str = "nothing";
            object expected = null;
            var actual = Kata.ParseF(str);
            Assert.AreEqual(expected, actual);
        }



        [TestMethod()]
        public void ParseFTest_GiveNnll_ThenNull()
        {
            object str = null;
            object expected = null;
            var actual = Kata.ParseF(str);
            Assert.AreEqual(expected, actual);
        }
    }
}
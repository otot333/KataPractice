using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPractice
{
    public class Kata
    {
        public static string Apple(object c)
        {
            var result = "";
            var number = 0;
            if (!Int32.TryParse(c.ToString(), out number))
            {
                throw new Exception("Can not parse object to int");
            };
            if (number * number > 1000)
            {
                result = "It's hotter than the sun!!";
            }
            else
            {
                result = "Help yourself to a honeycomb Yorkie for the glovebox.";
            }

            return result;
        }

        public static string FormatMoney(double amount)
        {
            var usadollor = amount.ToString("#,###.00");

            // your formatting code here
            return $"${usadollor}";
        }

        public static double? ParseF(object s = null)
        {
            var number = 0d;
            if (s != null && Double.TryParse(s.ToString(), out number))
            {
                return (double)number;
            }
            return null;
        }

        public static int[] InvertValues(int[] number)
        {
            return number.Select(x => x * (-1)).ToArray();
        }

        public static object Evil(int number)
        {
            var evilList = new List<int>() { 3, 5, 6, 9, 10, 12, 15, 17, 18, 20 };
            var odiousList = new List<int>() { 1, 2, 4, 7, 8, 11, 13, 14, 16, 19 };
            if (evilList.Contains(number))
                return "It's Evil!";
            else if (odiousList.Contains(number))
                return "It's Odious!";
            return "It's Odious!";
        }
    }
}

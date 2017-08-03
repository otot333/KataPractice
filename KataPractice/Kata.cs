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
            if (number == 0)
                return "";

            var binaryNumber = Convert.ToString(number, 2).ToArray().Select(x => x.ToString());
            var haveOneCount = (from num in binaryNumber
                                group num by num into oneCount
                                where oneCount.Key == "1"
                                select new { oneCount.Key, count = oneCount.Count() }).FirstOrDefault().count;

            if (haveOneCount % 2 == 0)
                return "It's Evil!";
            else
                return "It's Odious!";
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPractice
{
    public class Arge
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            var year = 0;
            percent = percent / 100;
            while (p0 < p)
            {
                var h = (p0 * percent);
                var k = (int)h;
                p0 += k + aug;
                year++;
            }

            // your code
            return year;

           
        }

        
    }
}

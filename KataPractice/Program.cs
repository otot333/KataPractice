using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt"));
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd H:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture));
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd h:mm:ss", System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}

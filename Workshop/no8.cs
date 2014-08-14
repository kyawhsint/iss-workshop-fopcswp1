using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    class no8
    {
        static void Main(string[] args)
        {
            // Convert Centigrade to Fahrenheit
            Console.WriteLine("Please enter temperature in Centigrade?");
            double ctemp = Convert.ToDouble(Console.ReadLine());
            double ftemp = 1.8 * ctemp + 32;
            Console.WriteLine("Convert {0} Centigrade to {1} Fahrenheit. ( Using This Formula : F= 1.8C + 32 )", ctemp, ftemp);
        }
    }
}

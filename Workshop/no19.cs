using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    class no19
    {
        static void Main(string[] args)
        {
            double sum;
            Console.WriteLine("Enter Kilometres?");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a <= 0.5)
            {
                sum = 2.40;
            }
            else if (a > 0.5 && a <= 9)
            {
                sum = 2.40 + ((a - 0.5)*100) * 0.4;
            }
            else
            {
                sum = 2.40 + ((a - 0.5) * 100) * 0.4 + (Math.Round(a, 1) - 9) * 0.5;
            }
            Console.WriteLine("Total Charge {0}", sum);
        }
    }
}

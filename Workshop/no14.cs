using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    class no14
    {
        static void Main(string[] args)
        {
            double a, b, c, s;
            Console.WriteLine("Enter lengths of triangle?");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter lengths of triangle?");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter lengths of triangle?");
            c = Convert.ToDouble(Console.ReadLine());
            s = (a + b + c) / 2;
            Console.WriteLine("AREA is : {0}", Math.Sqrt(s*(s - a)*(s - b)*(s - c)));
        }
    }
}

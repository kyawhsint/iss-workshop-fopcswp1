using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    class no10
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, dist;
            Console.WriteLine("Enter Number?");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number?");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number?");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number?");
            y2 = Convert.ToDouble(Console.ReadLine());
            dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("Distance is {0}", dist);
        }
    }
}

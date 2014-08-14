using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    class no9
    {
        static void Main(string[] args)
        {
            // Calculate x and y
            Console.WriteLine("Please enter number?");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 5 * x * x - 4 * x + 3;
            Console.WriteLine("Answer : {0} ( Using this formula : y= 5x2-4x+3 )", y);
        }
    }
}

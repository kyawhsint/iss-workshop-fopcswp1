using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    class no5
    {
        static void Main(string[] args)
        {
            // square root number with rounded 3 decimal places
            Console.WriteLine("Please enter double precision number?");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Math.Sqrt(num1);
            Console.WriteLine("{0:###.###} is the square root of this number {1}", num2, num1);
        }
    }
}

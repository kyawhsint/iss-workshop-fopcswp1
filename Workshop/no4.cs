using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    class no4
    {
        static void Main(string[] args)
        {
            // square root of double
            Console.WriteLine("Please enter double precision number?");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Math.Sqrt(num1);
            Console.WriteLine(num2 + " is the square root of this number " + num1);
        }
    }
}

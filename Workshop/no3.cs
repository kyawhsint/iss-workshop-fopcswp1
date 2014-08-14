using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    class no3
    {
        static void Main(string[] args)
        {
            // square of double
            Console.WriteLine("Please enter a double precision number?");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = num1 * num1;
            Console.WriteLine(num2 + " is the square of this number " + num1);
        }
    }
}

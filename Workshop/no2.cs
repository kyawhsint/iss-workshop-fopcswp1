using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    class no2
    {
        static void Main(string[] args)
        {
            // square of integer
            Console.WriteLine("Please enter an interger number?");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = num1 * num1;
            Console.WriteLine(num2 + " is the square of this number " + num1);
        }
    }
}

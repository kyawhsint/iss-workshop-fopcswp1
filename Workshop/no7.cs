using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    class no7
    {
        static void Main(string[] args)
        {
            // calculate salary
            Console.WriteLine("Please enter your salary?");
            double sal = Convert.ToDouble(Console.ReadLine());
            double total = sal + (10 * sal) / 100 + (3 * sal) / 100;
            Console.WriteLine("Total Salary is : {0:$###.##}", total);
        }
    }
}

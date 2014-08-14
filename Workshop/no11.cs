using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    class no11
    {
        static void Main(string[] args)
        {
            // Compute Taxi Charge
            Console.WriteLine("Please enter kilometer?");
            Console.WriteLine("Total Charges : {0:$###.##}", 2.40 + Convert.ToDouble(Console.ReadLine()) * 0.4); 
        }
    }
}

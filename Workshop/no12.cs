using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    class no12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Kilometers?");
            Console.WriteLine("Total Charges : {0}", Math.Round((2.40 + Convert.ToDouble(Console.ReadLine()) * 0.4),1));
        }
    }
}

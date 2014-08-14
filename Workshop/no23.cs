using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISS.RV.LIB;

namespace Workshop
{
    class no23
    {
        static void Main(string[] args)
        {
            int a, rnd, i;
            i = 0;
            do
            {
                rnd = ISSMath.RNDInt(9);
                Console.WriteLine("Enter number?");
                a = Convert.ToInt32(Console.ReadLine());
                i++;
            } while (rnd != a);
            if (i < 3)
            {
                Console.WriteLine("Times {0}.", i);
                Console.WriteLine("You are a Wizard!");
            }
            else if (i >= 3 && i < 6)
            {
                Console.WriteLine("Times {0}.", i);
                Console.WriteLine("You are lousy!");
            }
            else
            {
                Console.WriteLine("Times {0}.", i);
                Console.WriteLine("Try Again!");
            }
        }
    }
}

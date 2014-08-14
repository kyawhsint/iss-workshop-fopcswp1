using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    class no26
    {
        static void Main(string[] args)
        {
            for (double i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}\t\t\t{1:#.###}\t\t\t{2:#.###}\t\t\t{3}", i, 1 / i, Math.Sqrt(i), i * i);
            }
        }
    }
}

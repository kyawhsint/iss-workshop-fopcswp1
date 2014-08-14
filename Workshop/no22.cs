using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    class no22
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter number?");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number?");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                do
                {
                    c = a - b;
                } while (c == b);
                Console.WriteLine("A and B are equal with this number {0}",c);
                Console.WriteLine("Answer is {0}", (a * b) / c);
            }
            else
            {
                do
                {
                    c = b - a;
                } while (c == b);
                Console.WriteLine("B and A are equal with this number {0}.",c);
                Console.WriteLine("Answer is {0}", (a * b) / c);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    class no25
    {
        static void Main(string[] args)
        {
            // factorial
            int a, b, c;
            Console.Write("Enter Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <a; i++)
            //{
            //    //Console.WriteLine(i);
            //    for (int n = a; n >= 1; n--)
            //    {
            //        c = n * (n - i);
            //        Console.WriteLine(c);
            //        //Console.WriteLine("{0} and {1}.", i, n);
            //    }
            //}
            int n = 1;
            for (int i = a; i >= 1; i--)
            {
                i = i * i - 1;

                Console.WriteLine(i);
                n++;
            }
        }
    }
}

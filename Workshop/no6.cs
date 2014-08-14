using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    class no6
    {
        static void Main(string[] args)
        {
            // square root of integer
            Console.WriteLine("Please enter an integer number?");
            double num1 = Convert.ToInt32(Console.ReadLine());
            double num3 = Math.Sqrt(num1);
            Console.WriteLine("{0} is the square of this number {1}", num3, num1);

            //if (num1.GetType().Equals(typeof(int)))
            //{
            //    int num2 = Math.Sqrt(Convert.ToDouble(num1));
            //    Console.WriteLine("{0} is the square of this number {1}", num2, num1);
            //}
            //else if (num1.GetType().Equals(typeof(double)))
            //{
            //    double num3 = Math.Sqrt(num1);
            //    Console.WriteLine("{0} is the square of this number {1}", num3, num1);
            //}   
            //else
            //    Console.WriteLine("Error !!!");
        }
    }
}

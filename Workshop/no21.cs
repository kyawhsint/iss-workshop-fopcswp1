using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    class no21
    {
        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.WriteLine("Enter Number?");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a != 88);
            Console.WriteLine("Lucky you . . . ");
        }
    }
}

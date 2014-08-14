using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    class no16
    {
        static void Main(string[] args)
        {
            string gen;
            Console.WriteLine("Enter your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your gender? ( M or F assume capital letter )");
            string gender = Console.ReadLine();
            if (gender=="M")
                gen= "Mr. ";
            else
                gen= "Ms. ";
            Console.WriteLine("Good Morning " + gen + name + "\nwhere you enter " + name + " for name and " + gender + " for gender.");
        }
    }
}

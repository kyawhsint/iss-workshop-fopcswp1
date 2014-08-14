using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    class no17
    {
        static void Main(string[] args)
        {
            string name, gender, gen;
            int age;
            Console.WriteLine("Enter your name?");
            name = Console.ReadLine();
            Console.WriteLine("Enter your gender? ( M or F assume capital letter )");
            gender = Console.ReadLine();
            Console.WriteLine("Enter your age?");
            age = Convert.ToInt16(Console.ReadLine());
            if (gender == "M")
            {
                if (age >= 40)
                    gen = "Uncle ";
                else
                    gen = "Mr.";
            }
            else
            {
                if (age >= 40)
                    gen = "Aunty ";
                else
                    gen = "Ms.";
            }
            Console.WriteLine("Good Morning " + gen + name);
        }
    }
}

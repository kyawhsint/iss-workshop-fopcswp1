using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workshop
{
    class no18
    {
        static void Main(string[] args)
        {
            string grade;
            Console.WriteLine("Enter your marks?");
            int mark = Convert.ToInt16(Console.ReadLine());
            if (mark >= 80 && mark <= 100)
                grade = "A";
            else if (mark >= 60 && mark < 80)
                grade = "B";
            else if (mark >= 40 && mark < 60)
                grade = "C";
            else if (mark >= 0 && mark < 40)
                grade = "F";
            else
                grade = "** Error **";
            Console.WriteLine("Your grade is {0}.", grade);
        }
    }
}

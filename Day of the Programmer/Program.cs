using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_the_Programmer
{
    class Program
    {
        static string dayOfProgrammer(int year)
        {
            if (year == 1918)
            {
                return "26.09.1918";
            }
            if ((year < 1918 && year % 4 == 0) || (year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return "12.09." + year.ToString();
            }
            else
            {
                return "13.09." + year.ToString();
            }
        }
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine().Trim());

            string result = dayOfProgrammer(year);


        }
    }
}

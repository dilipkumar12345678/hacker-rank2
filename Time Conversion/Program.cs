using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = timeConversion(s);

            
        }

        static string timeConversion(string s)
        {
            DateTime dt = DateTime.Parse(s);

            return dt.ToString("HH:mm:ss");
        }
    }
}

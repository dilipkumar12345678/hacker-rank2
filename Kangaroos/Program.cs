using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x1V1X2V2 = Console.ReadLine().Split(' ');

            int x1 = Convert.ToInt32(x1V1X2V2[0]);

            int v1 = Convert.ToInt32(x1V1X2V2[1]);

            int x2 = Convert.ToInt32(x1V1X2V2[2]);

            int v2 = Convert.ToInt32(x1V1X2V2[3]);

            string result = kangaroo(x1, v1, x2, v2);

            Console.WriteLine(result);

            Console.ReadLine();
        }

        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            
            for (int i = 0; i < 1000; i++)
            {
                x1 = x1 + v1;
                x2 = x2 + v2;

                if (x1 == x2)
                    return "yes";
            }

            return "no";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            staircase(6);
            Console.ReadLine();
        }

        static void staircase(int n)
        {


            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j <= n - i)
                        Console.Write(" ");
                    else
                        Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }

}


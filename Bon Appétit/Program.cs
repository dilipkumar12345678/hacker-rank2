using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bon_Appétit
{
    class Program
    {
        static void bonAppetit(List<int> bill, int k, int b)
        {
            int actual = 0;
            int sum = 0;
            for (int i = 0; i < bill.Count; i++)
            {
                if (i == k)
                    continue;
                sum += bill[i];
            }

            actual = sum / 2;

            if (b - actual > 0)
                Console.WriteLine(b - actual);
            else
                Console.WriteLine("Bon Appetit");
            
        }
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            bonAppetit(bill, k, b);

            Console.ReadLine();
        }
    }
}

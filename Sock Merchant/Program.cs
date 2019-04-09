using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sock_Merchant
{
    class Program
    {
        static int sockMerchant(int n, int[] ar)
        {
            var t = ar.ToList().Distinct();
            int pairs = 0;

            foreach (var item in t)
            {
                int count = (ar.Where(x => x == item).Count());
                int temp = 0;
                if (count > 1)
                    temp = count / 2;
                if (temp > 0)
                    pairs += temp;
            }
            return pairs;
        }
        static void Main(string[] args)
        {


            int n = Convert.ToInt32(Console.ReadLine());

            string[] temp = Console.ReadLine().Split(' ');
            string t = temp.ToList().Last();

            if ((t == " ") || (t == ""))
            {
                temp.ToList().RemoveAt(temp.Length - 1);
                
            }

           
            int[] ar = Array.ConvertAll(temp.ToArray<string>(), arTemp => Convert.ToInt32(arTemp));

            int result = sockMerchant(n, ar);

           // Console.ReadLine();

        }
    }
}

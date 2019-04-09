using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Cake_Candles
{
    class Program
    {
        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = birthdayCakeCandles(ar);
        }

        static int birthdayCakeCandles(int[] ar)
        {

            Dictionary<int, int> dct = new Dictionary<int, int>();

            foreach (var item in ar)
            {
                if (dct.ContainsKey(item))
                {
                    dct[item]++;
                }
                else
                {
                    dct[item] = 1;
                }
            }

           
            return dct[dct.Keys.Max()];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSum
{
    class Program
    {
        static void miniMaxSum(int[] arr)
        {
            Int64 minsum = 0;
            Int64 maxsum = 0;

            List<int> arrlst = arr.ToList();

            arrlst.Sort();

            for (int i = 0; i < arrlst.Count; i++)
            {
                minsum += arr[i];
            }

            maxsum = minsum;
            minsum = minsum - arrlst[(arr.Length) - 1];
            maxsum = maxsum - arrlst[0];

            Console.WriteLine(minsum + " " + maxsum);


        }
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            miniMaxSum(arr);
        }
    }
}

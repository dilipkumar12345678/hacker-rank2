using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addLargeintergers
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static long aVeryBigSum(long[] ar)
        {
            long sum = 0;
            foreach (var item in ar)
            {
                sum += item;
            }

            return sum;
        }
    }
}

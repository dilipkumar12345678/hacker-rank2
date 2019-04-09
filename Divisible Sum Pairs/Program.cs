﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible_Sum_Pairs
{
    class Program
    {
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if(((ar[i]+ar[j]) % k == 0))
                        count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            
            int result = divisibleSumPairs(n, k, ar);
        }
    }
}

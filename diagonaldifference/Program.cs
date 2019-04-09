using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagonaldifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = diagonalDifference(arr);

            // textWriter.WriteLine(result);

            // textWriter.Flush();
            // textWriter.Close();
            Console.ReadLine();
        }

        static int diagonalDifference(int[][] arr)
        {



            int arrsumleft = 0;
            int tempright = 0;
            int templeft = (arr.GetLength(0)) - 1;
            int arrsumright = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                //   arrsumleft = arrsumleft + arr[i, tempright++];
                //   arrsumright = arrsumright + arr[i, templeft--];

                arrsumleft = arrsumleft + arr[i][tempright++];
                arrsumright = arrsumright + arr[i][templeft--];
            }



            return Math.Abs(arrsumleft - arrsumright);
        }
    }
}

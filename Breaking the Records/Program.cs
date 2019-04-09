using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breaking_the_Records
{
    class Program
    {
        static int[] breakingRecords(int[] scores)
        {
            int min = scores[0];
            int max = scores[0];
            int[] minmaxcount = new int[2] ;
            

            foreach (var item in scores)
            {
                if(item < min)
                {
                    min = item;
                    minmaxcount[1]++;
                }
                if(item > max)
                {
                    max = item;
                    minmaxcount[0]++;
                }
            }

            return minmaxcount;
        }

        static void Main(string[] args)
        {
            

            int n = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
            
            int[] result = breakingRecords(scores);

            Console.ReadLine();
        }
    }
}

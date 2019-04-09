using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migratory_Birds
{
    class Program
    {
        static int migratoryBirds(List<int> arr)
        {
            int max = arr.Max();
            int min = arr.Min();
            Dictionary<int, int> dct = new Dictionary<int, int>();

            for (int i = min; i < max; i++)
            {
                var temp = arr.Where(x => x == i).Count();
                dct.Add(i, temp);
            }

            int occur = dct.Where(pair => pair.Value == dct.Max(x => x.Value)).Select(pair => pair.Key).First();


            return occur;
        }

        static int migratoryBirds2(List<int> arr)
        {

            int[] counter = new int[6];
            int result = 1; int max = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                counter[arr[i]]++;
            }

            for (int i = 1; i <= 5; i++)
            {
                if (counter[i] > max)
                {
                    result = i;
                    max = counter[i];
                }
            }

            return result;



        }

        static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Chocolate
{
    class Program
    {
        static int birthday(List<int> s, int d, int m)
        {
            int count = 0;
            for(int i=0; i< s.Count; i++)
            {
                int sum = 0;

                int nextnos = i + m;

                if (nextnos > s.Count)
                    break;

                for(int j =i; j< i+m; j++)
                {
                    sum += s[j];
                }

                if (d == sum)
                    count++;

            }
            return count; ;
        }
        static void Main(string[] args)
        {
           

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = birthday(s, d, m);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}

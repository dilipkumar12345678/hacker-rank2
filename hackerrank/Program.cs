using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static List<int> compareTriplets(List<int> a, List<int> b)
        {

            List<int> t = new List<int>();
            int c = 0; int d = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    c++;
                }
                else if (a[i] == b[i])
                {

                }
                else
                {
                    d++;
                }
            }

            
            

            return t;
        }

    }
}

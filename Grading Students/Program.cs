using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_Students
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] grades = new int[n];

            for (int gradesItr = 0; gradesItr < n; gradesItr++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine());
                grades[gradesItr] = gradesItem;
            }

            int[] result = gradingStudents(grades);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        static int[] gradingStudents(int[] grades)
        {
            int[] newgrades = new int[grades.Length];

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] < 38)
                {
                    newgrades[i] = grades[i];
                }
                else
                {
                    int quotient = grades[i] / 5;
                    int multiple = quotient * 5;
                    int diff = (multiple + 5) - grades[i]  ;

                    if(diff < 3)
                    {
                        newgrades[i] = multiple + 5;
                    }
                    else
                    {
                        newgrades[i] = grades[i];
                    }
                }
            }

            return newgrades;
        }
    }
}

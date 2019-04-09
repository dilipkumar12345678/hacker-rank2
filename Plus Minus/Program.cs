using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_Minus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            plusMinus(arr);
        }

        static void plusMinus(int[] arr)
        {
            decimal poscount = 0;
            decimal negcount = 0;
            decimal zerocount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    negcount++;
                else if (arr[i] > 0)
                    poscount++;
                else
                    zerocount++;
            }

            decimal positive = 0;
            decimal negative = 0;
            decimal zero = 0;


            if (poscount > 0)
            {
                positive = Math.Round((poscount / arr.Length), 6);
                if (!positive.ToString().Contains('.'))
                {
                    positive = Convert.ToDecimal(positive.ToString() + ".000000");
                }
                else
                {
                    int lenght = positive.ToString().Substring(positive.ToString().IndexOf('.') + 1).Length;
                    int res = 6 - lenght;
                    if (res > 0)
                    {
                        string temp = positive.ToString();
                        for (int i = 0; i < res; i++)
                        {
                            temp = temp + "0";
                        }
                        positive = Convert.ToDecimal(temp);
                    }
                }

            }
            else
            {
                positive = Convert.ToDecimal("0.000000");
            }
            if (negcount > 0)
            {
                negative = Math.Round((negcount / arr.Length), 6);
                if (!negative.ToString().Contains('.'))
                {
                    negative = Convert.ToDecimal(negative.ToString() + ".000000");
                }
                else
                {
                    int lenght = negative.ToString().Substring(negative.ToString().IndexOf('.') + 1).Length;
                    int res = 6 - lenght;
                    if (res > 0)
                    {
                        string temp = negative.ToString();
                        for (int i = 0; i < res; i++)
                        {
                            temp = temp + "0";
                        }
                        negative = Convert.ToDecimal(temp);
                    }
                }
            }
            else
            {
                negative = Convert.ToDecimal("0.000000");
            }
            if (zerocount > 0)
            {
                zero = Math.Round((zerocount / arr.Length), 6);

                if (!zero.ToString().Contains('.'))
                {
                    zero = Convert.ToDecimal(zero.ToString() + ".000000");
                }
                else
                {
                    int lenght = zero.ToString().Substring(zero.ToString().IndexOf('.') + 1).Length;
                    int res = 6 - lenght;
                    if (res > 0)
                    {
                        string temp = zero.ToString();
                        for (int i = 0; i < res; i++)
                        {
                            temp = temp + "0";
                        }
                        zero = Convert.ToDecimal(temp);
                    }
                }
            }
            else
            {
                zero = (Convert.ToDecimal("0.000000"));
            }

            Console.WriteLine(positive);
            Console.WriteLine(negative);
            Console.WriteLine(zero);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int s = int.Parse(Console.ReadLine());
            int sum = 0;
            int ind = 0;
            for (int j = 0; j < n; j++)
            {
                sum = sum + a[j];
                if (sum < s)
                {
                    if (j < n - 1)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("No");
                        break;
                    }
                }
                else
                {
                    while (sum > s)
                    {
                        sum = sum - a[ind];
                        ind++;
                    }
                }
                if (sum == s)
                {
                    for (int k = ind; k <= j; k++)
                    {
                        Console.WriteLine(a[k]);
                    }
                    break;
                }
                else if ((sum < s) && (j == n - 1))
                {
                    Console.WriteLine("No");
                    break;
                }
            }

        }
    }
}

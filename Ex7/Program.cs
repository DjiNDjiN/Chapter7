using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            int maxSum = 0;
            for (int i = 0; i < k; i++)
            {
                maxSum = maxSum + a[i];
            }
            int start = 0;
            for (int i = 1; i < n - k + 1; i++)
            {
                sum = maxSum + a[i - 1 + k] - a[i - 1];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    start = i;
                }
                else
                {
                    continue;
                }
                sum = 0;
            }
            for (int i = start; i < k + start; i++)
            {
                Console.WriteLine(a[i]);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
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
            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 1;
            for (int i = 1; i < n; i++)
            {
                if (a[i] > a[i - 1])
                {
                    len++;
                    if (len == 2)
                    {
                        start = i - 1;
                    }
                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestStart = start;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    len = 1;
                }
            }
            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.WriteLine(a[i]);
            }

        }
    }
}

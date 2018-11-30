using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            //binary search
            Console.WriteLine("to search: ");
            int toSearch = int.Parse(Console.ReadLine());
            int begin = 0, end = n - 1;
            while (begin <= end)
            {
                int mid = (begin + end) / 2;
                if (toSearch == array[mid])
                {
                    break;
                }
                else
                {
                    if (toSearch > array[mid])
                    {
                        begin = mid;
                    }
                    else
                    {
                        end = mid;
                    }

                }
            }
            int position = (begin + end) / 2;
            Console.WriteLine("{0} - {1}", array[position], position);

        }
    }
}

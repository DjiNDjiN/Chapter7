using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
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
            int maxSum = 0;
            int currentSum = 0;
            for (int i = 0; i < n; i++)
            {
                currentSum += array[i];
                if (currentSum > maxSum)
                    maxSum = currentSum;
                if (currentSum < 0)
                    currentSum = 0;
            }
            Console.WriteLine(maxSum);

        }
    }
}

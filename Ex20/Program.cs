using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20
{
    class Program
    {
        static void Main()
        {
            int S = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int subsetsCount = (int)Math.Pow(2, n);
            for (int i = 1; i < subsetsCount; i++)
            {
                int sum = 0;
                int bitsOfI = i;
                for (int j = 0; j < n; j++)
                {
                    if (bitsOfI % 2 == 1)
                    {
                        sum += array[j];
                    }
                    bitsOfI = bitsOfI >> 1;
                }
                if (sum == S)
                {
                    Console.WriteLine("True");
                    return;
                }
            }
            Console.WriteLine("False");
        }

    }
}

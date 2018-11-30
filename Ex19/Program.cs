using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = new int[10000000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (i + 1);
            }
            
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    for (int j = 2; j <= array.Length / (i + 1); j++)
                    {
                        array[(j * (i + 1)) - 1] = 0;
                    }
                }
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    Console.WriteLine(array[i]);
                }
            }

        }
    }
}

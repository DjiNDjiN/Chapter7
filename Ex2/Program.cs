using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstArrayLength = int.Parse(Console.ReadLine());
            int secondArrayLength = int.Parse(Console.ReadLine());
            if (firstArrayLength != secondArrayLength)
            {
                Console.WriteLine("False");
                return;
            }

            int[] firstArray = new int[firstArrayLength];
            for (int i = 0; i < firstArrayLength; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            int[] secondArray = new int[secondArrayLength];
            for (int i = 0; i < secondArrayLength; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < firstArrayLength; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine("False");
                    return;
                }
            }
            Console.WriteLine("True");

        }
    }
}

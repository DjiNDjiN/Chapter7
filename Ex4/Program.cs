using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayInt = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayInt[i] = int.Parse(Console.ReadLine());
            }
            int arrLength = arrayInt.Length;
            int tempElement = arrayInt[0];
            int tempLength = 1;
            int maxLength = 0;
            int element = new int();

            for (int i = 1; i < arrLength; i++)
            {
                if (arrayInt[i] == tempElement)
                {
                    tempLength++;
                }
                else
                {
                    if (tempLength > maxLength)
                    {
                        element = arrayInt[i - 1];
                        maxLength = tempLength;
                    }
                    tempLength = 1;
                }
            }

            for (int i = 0; i < maxLength; i++)
            {
                Console.Write("{0}, ", element);
            }

        }
    }
}

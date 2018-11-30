using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequenceStr = Console.ReadLine();
            string[] sequenceTokens = sequenceStr.Split();
            int[] arrayInt = new int[sequenceTokens.Length];
            for (int i = 0; i < sequenceTokens.Length; i++)
            {
                arrayInt[i] = int.Parse(sequenceTokens[i]);
            }
            Array.Sort(arrayInt);
            int count = 1;
            int maxNumber = arrayInt[0];
            int maxCount = 1;
            for (int i = 1; i < arrayInt.Length; i++)
            {
                if (arrayInt[i - 1] == arrayInt[i])
                {
                    count++;
                    if (maxCount < count)
                    {
                        maxCount = count;
                        maxNumber = arrayInt[i - 1];
                    }
                }
                else
                {
                    count = 1;
                }
            }
            Console.WriteLine(maxNumber + "-" + maxCount);

        }
    }
}

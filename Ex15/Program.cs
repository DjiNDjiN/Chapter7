using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] word = new char[n];
            for (int i = 0; i < n; i++)
            {
                word[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                int index = (int)word[i] - (int)'A' + 1;
                Console.WriteLine(index);

            }
        }
    }
}

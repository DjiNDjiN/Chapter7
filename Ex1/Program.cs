using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int[] a = new int[m];
            for (int i = 0; i < m; i++)
            {
                a[i] = i * 5;
                Console.WriteLine(a[i]);
            }

        }
    }
}

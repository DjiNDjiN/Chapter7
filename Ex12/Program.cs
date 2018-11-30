using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    using System;
    class PrintsMatrixSizeNN
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int N = int.Parse(str);
            int[,] arrNN = new int[N, N];

            int k = 0;
            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < N; j++)
                {
                    arrNN[j, i] = i + j + k + 1;
                }
                k += N - 1;
            }

            for (int i = 0; i < arrNN.GetLength(0); i++)
            {
                for (int j = 0; j < arrNN.GetLength(1); j++)
                {
                    Console.Write("{0}", arrNN[i, j].ToString().PadRight((N * N).ToString().Length + 1));
                }
                if (i != arrNN.GetLength(0))
                {
                    Console.WriteLine();
                }
            }
        }
    }
//B)

class PrintsMatrixSizeNN1
    {
        static void Mai()
        {
            string str = Console.ReadLine();
            int N = int.Parse(str);
            int[,] arrNN = new int[N, N];

            int k = 0;
            for (int i = 0; i < N; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 1; j <= N; j++)
                    {
                        arrNN[j - 1, i] = i + j + k;
                    }
                    k += 2 * N - 1;
                }
                else
                {
                    for (int j = 0; j < N; j++)
                    {
                        arrNN[j, i] = i - j + k;
                    }
                    k -= 1;
                }
            }
            for (int i = 0; i < arrNN.GetLength(0); i++)
            {
                for (int j = 0; j < arrNN.GetLength(1); j++)
                {
                    Console.Write("{0}", arrNN[i, j].ToString().PadRight((N * N).ToString().Length + 1));
                }
                if (i != arrNN.GetLength(0))
                {
                    Console.WriteLine();
                }
            }
        }
    }
//C)

class PrintMatrixSizeNN
    {
        static void Ma()
        {
            string line = Console.ReadLine();
            int sizeOfMatrix = int.Parse(line);
            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];

            int side = matrix.GetLength(0);
            int coordX = side - 1;
            int coordY = 0;
            for (int counter = 1; counter <= side * side; counter++)
            {
                matrix[coordX, coordY] = counter;
                int nextX = coordX + 1;
                int nextY = coordY + 1;
                if (nextX == side && nextY != side)
                {
                    coordX = (side - coordY - 2);
                    coordY = 0;
                }
                else if (nextY == side)
                {
                    coordY = (side - coordX);
                    coordX = 0;
                }
                else
                {
                    coordX = nextX;
                    coordY = nextY;
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}", matrix[i, j].ToString().PadRight((sizeOfMatrix * sizeOfMatrix).ToString().Length + 1));
                }
                if (i != matrix.GetLength(0))
                {
                    Console.WriteLine();
                }
            }
        }
    }
//D)

class PrintQuadraticMatrix
    {
        static void M()
        {
            string line = Console.ReadLine();
            int sizeOfMatrix = int.Parse(line);
            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
            int xCoord = 0;
            int yCoord = 0;
            int directorion = 0;
            int side = matrix.GetLength(0);
            int[,] navigator = {
                                { 1, 0 },
                                { 0, 1 },
                                { -1, 0 },
                                { 0, -1 }
                                };
            for (int iterator = 1; iterator <= side * side; iterator++)
            {
                matrix[xCoord, yCoord] = iterator;
                int nextXcoord = xCoord + navigator[directorion, 0];
                int nextYcoord = yCoord + navigator[directorion, 1];
                if (nextXcoord == side || nextXcoord == -1 || nextYcoord == side || nextYcoord == -1
                    || matrix[nextXcoord, nextYcoord] != 0)
                {
                    directorion++;
                    directorion %= 4;
                }
                xCoord += navigator[directorion, 0];
                yCoord += navigator[directorion, 1];
            }
            //print
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}", matrix[i, j].ToString().PadRight((sizeOfMatrix * sizeOfMatrix).ToString().Length + 1));
                }
                if (i != matrix.GetLength(0))
                {
                    Console.WriteLine();
                }
            }
        }
    }

}

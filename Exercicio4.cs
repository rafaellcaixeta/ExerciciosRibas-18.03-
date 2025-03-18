using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5];
            int valor = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = valor;
                    valor++;
                }
            }

            Console.WriteLine("Valores das diagonais da matriz 5x5:\n");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j || i + j == 4)
                    {
                        Console.WriteLine(matriz[i, j] + "\t");
                    }
                    else
                    {
                        Console.WriteLine("\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 3];
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            Console.WriteLine($"Digite {linhas * colunas} números inteiros para colocar na matriz:");

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"Digite número para colcoar na posição [{i}, {j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("\nSoma dos valores de cada linha:");

            for (int i = 0; i < linhas; i++)
            {
                int soma = 0;
                for (int j = 0; j < colunas; j++)
                {
                    soma += matriz[i, j];
                }
                Console.WriteLine($"Soma da linha {i + 1}: {soma}");
            }
        }
    }
}
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[15];

            Console.WriteLine("Escreva 15 números inteiros:");

            for (int i = 0; i < 15; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Os números que estão armazenados nas posições pares são:");
            for (int i = 0; i < 15; i += 2)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
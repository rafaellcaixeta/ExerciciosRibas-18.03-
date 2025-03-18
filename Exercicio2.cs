using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = new string[10];
            double[] precos = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite um produto {i + 1}:");
                produtos[i] = Console.ReadLine();

                Console.WriteLine($"Digite o preço desse produto {i + 1}:");
                precos[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite um valor para aparecer todos até o valor desejado:");
            double valorFiltro = double.Parse(Console.ReadLine());

            Console.WriteLine("Produtos com preço até R$ " + valorFiltro.ToString("F2") + ":");
            bool encontrou = false;

            for (int i = 0; i < 10; i++)
            {
                if (precos[i] <= valorFiltro)
                {
                    Console.WriteLine($"{produtos[i]} - R$ {precos[i]:F2}");
                    encontrou = true;
                }
            }
        }
    }
}

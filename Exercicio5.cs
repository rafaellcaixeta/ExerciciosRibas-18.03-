using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[10];
        double[,] notas = new double[10, 3];
        double[] medias = new double[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o nome do aluno(a) {i + 1}: ");
            nomes[i] = Console.ReadLine();

            double soma = 0;
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Digite a nota {j + 1} do(a) {nomes[i]}: ");
                notas[i, j] = Convert.ToDouble(Console.ReadLine());
                soma += notas[i, j];
            }
            medias[i] = soma / 3;
        }

        Console.WriteLine("\n--- BOLETINHO FINAL ---\n");
        
        for (int i = 0; i < 10; i++)
        {
            if (medias[i] >= 7.0)
                Console.ForegroundColor = ConsoleColor.Blue;
            else
                Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"Aluno(a): {nomes[i]}");

            Console.Write("Notas: ");

            for (int j = 0; j < 3; j++)
            {
                Console.Write(notas[i, j] + " ");
            }
            Console.WriteLine($"\nMédia: {medias[i]:F2}");
            Console.WriteLine(medias[i] >= 7.0 ? "Aprovado" : "Reprovado");
        }
        Console.ResetColor();
    }
}
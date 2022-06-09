using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Atividade 3 - Divisão ");
        Console.WriteLine();

        int N, x, y, divisao;

        Console.WriteLine("Quantos casos você vai digitar");
        N = int.Parse(Console.ReadLine());

        for(int i = 1; i <= N; i++)
        {
            Console.WriteLine("Entre com o numerador: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o denominador");
            y = int.Parse(Console.ReadLine());

            if (y == 0)
            {
                Console.WriteLine("Divisão impossível");
            }
            else
            {
                divisao = x / y;
                Console.WriteLine();
                Console.WriteLine("Divisão = " + divisao);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}
using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Projeto 4 - Repita ");
        Console.WriteLine();

        int c, f;
        char resp;

        do
        {
            Console.WriteLine("Digite a temperatura em Celsius");
            c = int.Parse(Console.ReadLine());

            f = 9 * c / 5 + 32;

            Console.WriteLine("Equivalente em Fahrenheit: " + f);

            Console.WriteLine("Deseja repetir (s/n) ");
            resp = char.Parse(Console.ReadLine());

        } while (resp == 's');


        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}
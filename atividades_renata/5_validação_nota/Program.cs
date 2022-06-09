using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Validação Nota ");
        Console.WriteLine();

        int nota1, nota2, media;

        Console.WriteLine("Digite a primeira nota: ");
        nota1 = int.Parse(Console.ReadLine());

            while(nota1 < 0 || nota1 > 10)
            {
                Console.WriteLine("Valor inválido!");
                break;
            }

        Console.WriteLine("Digite a segunda nota: ");
        nota2 = int.Parse(Console.ReadLine());

             while (nota2 < 0 || nota2 > 10)
             {   
                Console.WriteLine("Valor inválido!");
                break;
             }

        media = (nota1 + nota2) / 2;
        Console.WriteLine("Média = " + media);

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}
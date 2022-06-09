using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Projeto - Vetor com FOR ");
        Console.WriteLine();

        int Qtdalunos;

        Console.WriteLine("Qual a quantidade de alunos que deseja armazenar");
        Qtdalunos = int.Parse(Console.ReadLine());

        string[] vetorAlunos = new string[Qtdalunos];

        for (int indiceVetorAlunos = 0; indiceVetorAlunos < Qtdalunos; indiceVetorAlunos++)
        {
            string NomeAluno;

            Console.WriteLine("Informe o nome do aluno: ");
            vetorAlunos[indiceVetorAlunos] = Console.ReadLine();
        }

        char Imprime;

        Console.WriteLine(); Console.WriteLine("Digite 's' para imprimir os nomes dos Alunos ");
        Imprime = char.Parse(Console.ReadLine());

        if (Imprime == 's' || Imprime == 'S')
        {
            
            for (int indiceVetorAlunos = 0; indiceVetorAlunos < Qtdalunos; indiceVetorAlunos++)
            {
                Console.WriteLine("Nome do Aluno: " + vetorAlunos[indiceVetorAlunos]);
            }

        }

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}
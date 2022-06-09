using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Projeto  - Dois Vetores");
        Console.WriteLine();

        int qntdAlunos;

        Console.WriteLine("Qual a quantidade de alunos na sala? ");
        qntdAlunos = int.Parse(Console.ReadLine());

        string[] VetorAlunos = new string[qntdAlunos];
        float[] VetorNotas = new float[qntdAlunos];


        for (int i = 0; i < qntdAlunos; i++)
        {
            Console.WriteLine("Informe o nome do Aluno: ");
            VetorAlunos[i] = Console.ReadLine();

            Console.WriteLine("Informe a nota desse Aluno: ");
            VetorNotas[i] = float.Parse(Console.ReadLine());

        }

        char Imprime;

        Console.WriteLine();
        Console.Write("Digite 'S' para imprimir os nomes dos Alunos: ");
        Imprime = char.Parse(Console.ReadLine()); Console.WriteLine();

        if (Imprime == 'S' || Imprime == 's')
        {
            for (int IndiceAluno = 0; IndiceAluno < qntdAlunos; IndiceAluno++)
            {
                Console.WriteLine($"Aluno N. {IndiceAluno + 1} chama-se : {VetorAlunos[IndiceAluno].ToUpper()}");
                Console.WriteLine($"Aluno N. {IndiceAluno + 1} tem a nota : {VetorNotas[IndiceAluno]}");
            }
        }
    }
}
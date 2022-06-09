using System;

class aprovados
{
    static void Main(string[] args)

    {
        Console.WriteLine("Projeto  -  aprovados");
        Console.WriteLine();

        int N;
        double media;

        Console.WriteLine("Quantos alunos serão digitados");
        N = int.Parse(Console.ReadLine());

        string[] nomes = new string[N];
        double[] notas1 = new double[N];
        double[] notas2 = new double[N];

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Digite o Nome, Primeira e Segunda nota do " + (i + 1) + "º Aluno");
            nomes[i] = Console.ReadLine();
            notas1[i] = double.Parse(Console.ReadLine());
            notas2[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Alunos aprovados: ");

        for (int i = 0; i < N; i++)
        {
            media = (notas1[i] + notas2[i]) / 2;

            if(media >= 6)
            {
                Console.WriteLine(nomes[i]);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}
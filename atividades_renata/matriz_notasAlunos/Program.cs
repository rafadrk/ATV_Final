using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Projeto  -  Notas usando Matriz");
        Console.WriteLine();

            char Imprime;
            int qtdAlunos;
            int n1;
            int n2;
            int notas = n1 + n2;

        Console.WriteLine("Quantidade de alunos da turma:");
        qtdAlunos = int.Parse(Console.ReadLine());

            double[ , ] MatrizDuasNotas = new double[qtdAlunos, notas];

        for(int IndiceMatrizAlunos = 0; IndiceMatrizAlunos < qtdAlunos; IndiceMatrizAlunos++)
        {
            for (int IndiceColunaAlunos = 0; IndiceColunaAlunos < qtdAlunos; IndiceColunaAlunos++)
            {
                Console.WriteLine("Informe a nota do Aluno:" + (MatrizDuasNotas[IndiceMatrizAlunos, IndiceColunaAlunos] = double.Parse(Console.ReadLine())));
            }
        }

        Console.WriteLine();
        Console.Write("Digite 'S' para imprimir os nomes dos Alunos: ");
        Imprime = char.Parse(Console.ReadLine()); Console.WriteLine();

        if (Imprime == 'S' || Imprime == 's')
        {
            for(int IndiceMatrizAlunos = 0; IndiceMatrizAlunos < qtdAlunos; IndiceMatrizAlunos++)
            {
                for (int IndiceColunaAlunos = 0; IndiceColunaAlunos < qtdAlunos; IndiceColunaAlunos++)
                {

                    Console.WriteLine("Nota do aluno:" + MatrizDuasNotas[IndiceMatrizAlunos, IndiceColunaAlunos]);
                   
                }

            }
        }

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}
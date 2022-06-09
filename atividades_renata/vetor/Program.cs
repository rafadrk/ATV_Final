using System;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Projeto - Vetores ");
        Console.WriteLine();

        string[] alunosMDS = new string[16]; //Declaração do vetor  e a definição do seu tamanho
        int imprimeAluno;

        Console.WriteLine("Informe o nome do 1º Aluno");
        alunosMDS[0] = Console.ReadLine();
        Console.WriteLine("Informe o nome do 2º Aluno");
        alunosMDS[1] = Console.ReadLine();
        Console.WriteLine("Informe o nome do 3º Aluno");
        alunosMDS[2] = Console.ReadLine();
        Console.WriteLine("Informe o nome do 4º Aluno");
        alunosMDS[3] = Console.ReadLine();
        Console.WriteLine("Informe o nome do 5º Aluno");
        alunosMDS[4] = Console.ReadLine();
        Console.WriteLine("Informe o nome do 6º Aluno");
        alunosMDS[5] = Console.ReadLine();
        Console.WriteLine("Informe o nome do 7º Aluno");
        alunosMDS[6] = Console.ReadLine();
        Console.WriteLine("Informe o nome do 8º Aluno");
        alunosMDS[7] = Console.ReadLine();
        Console.WriteLine("Informe o nome do 9º Aluno");
        alunosMDS[8] = Console.ReadLine();
        Console.WriteLine("Informe o nome do 10º Aluno");
        alunosMDS[9] = Console.ReadLine();
        Console.WriteLine("Informe o nome do 11º Aluno");
        alunosMDS[10] = Console.ReadLine();
        Console.WriteLine("Informe o nome do 12º Aluno");
        alunosMDS[11] = Console.ReadLine();
        Console.WriteLine("Informe o nome do 13º Aluno");
        alunosMDS[12] = Console.ReadLine();
        Console.WriteLine("Informe o nome do 14º Aluno");
        alunosMDS[13] = Console.ReadLine();
        Console.WriteLine("Informe o nome do 15º Aluno");
        alunosMDS[14] = Console.ReadLine();
        Console.WriteLine("Informe o nome do 16º Aluno");
        alunosMDS[15] = Console.ReadLine();


        do
        {
            Console.WriteLine();
            Console.WriteLine("Qual aluno você deseja imprimir? ");
            imprimeAluno = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome do " + imprimeAluno + " aluno: " + alunosMDS[imprimeAluno - 1].ToUpper());

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();

        } while (imprimeAluno <= 16);
    }
}
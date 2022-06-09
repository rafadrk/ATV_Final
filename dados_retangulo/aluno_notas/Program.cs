using System;

namespace aluno_notas
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto  - Notas de Aluno ");
            Console.WriteLine();

            aluno aluno = new aluno();

            Console.WriteLine("--------------- DADOS DO ALUNO ----------------");
            Console.WriteLine("Nome de Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());

            if (aluno.Nota1 > 30)
            {
               Console.WriteLine("Esta nota é invalida!");
                return;
            } 
            else if (aluno.Nota2 > 35 && aluno.Nota3 > 35)
            {
                Console.WriteLine("Esta nota é invalida!");
                return;
            }

            double totalnota = aluno.TotalNota();

            Console.WriteLine("Agora iremos calcular sua nota final...");
            Console.WriteLine("Pressione ENTER para o calcular.");
            Console.ReadLine();

            Console.WriteLine("Nota Final = " + totalnota);

            if(totalnota >= 60)
            {
                Console.WriteLine("Você foi aprovado");
            } else
            {
                Console.WriteLine("Você foi reprovado");
                Console.WriteLine("Faltaram " + (60 - totalnota) + " pontos...");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();
        }
    }
}
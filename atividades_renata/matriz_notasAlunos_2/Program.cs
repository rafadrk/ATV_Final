using System;
using System.Globalization;

namespace MatrizNotasPorAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            int QtdeAlunos, QtdeNotas; 

            Console.WriteLine("SENAI SP - VOTUPORANGA - MDS TEC. EM DESENVOLVIMENTO DE SISTEMAS - 2022");
            Console.WriteLine("=======================================================================");
            Console.WriteLine("Projeto Matrizes - Armazenamento das Notas dos Alunos da Turma MDS 2022");
            Console.WriteLine("=======================================================================");
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); 
            Console.WriteLine("Informe a Quantidade de Alunos da Turma:"); 
            QtdeAlunos = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Informe a Quantidade de Notas por Aluno:");
            QtdeNotas = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double[,] MatrizNotasPorAlunos = new double[QtdeAlunos, QtdeNotas];
            
            for (int NumAluno = 0; NumAluno < QtdeAlunos; NumAluno++)
            
            {
               
                for (int NumNota = 0; NumNota < QtdeNotas; NumNota++)
                
                {
                    Console.Write("Informe a Nota N. {0} do Aluno N. {1}: ", NumNota + 1, NumAluno + 1);
                    MatrizNotasPorAlunos[NumAluno, NumNota] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("                  *  NOTAS DOS ALUNOS  *                           ");
            Console.WriteLine("=======================================================================");

            //Declaração das variáveis que armazenação a Média das Notas por Aluno.

            for (int NumAluno = 0; NumAluno < QtdeAlunos; NumAluno++)
            {
                double SomaNotas = 0.00;
                double MediaNotas = 0.00;

                for (int NumNota = 0; NumNota < QtdeNotas; NumNota++)
                {
                    Console.WriteLine($"Aluno N. {NumAluno + 1} | Nota N. {NumNota + 1} : {MatrizNotasPorAlunos[NumAluno, NumNota]:F1}"); //Consele.Write com uso de INTERPOLAÇÃO
                    SomaNotas += MatrizNotasPorAlunos[NumAluno, NumNota];
                }
                MediaNotas = (double)SomaNotas / (double)QtdeNotas;
                Console.WriteLine("A SOMA das Notas do Aluno N. " + NumAluno + 1 + " é :" + SomaNotas.ToString("F1") + " e a MÉDIA dele é " + MediaNotas.ToString("F1"));
                Console.WriteLine();
            }
        }
    }
}
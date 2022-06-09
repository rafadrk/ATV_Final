using System;

namespace quartocomvetor
{
    class programa
    {
        static void Main(string[] args)
        {

            Console.WriteLine("digite a quatidade de quartos disponíveis:");
            int qtdquartos = int.Parse(Console.ReadLine());
            //Armazena o tamanho do vetor em variável

            Estudante[] quarto = new Estudante[ qtdquartos ];
            //Declara o vetor da classe

            for(int i = 0; i < qtdquartos; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Dados do Hóspede: " + (i + 1));
                Console.Write("Nome : ");
                string nome = Console.ReadLine();
                Console.Write("Endereço : ");
                string endereco = Console.ReadLine();
                Console.Write("Email : ");
                string email = Console.ReadLine();

                quarto[i] = new Estudante(nome, endereco, email);
            }

            for(int i = 0; i < qtdquartos; i++)
            {
                Console.WriteLine(quarto[i]);
            }
        }
    }
}
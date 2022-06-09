
namespace dados_pessoais
{
    using System;

    class Programa
    {
        static void Main(string[] args)
        {

            Nome nomes;
            idades idades;
         
            nomes = new Nome();
            idades = new idades();
           

            Console.WriteLine("Dados da 1ª pessoa: ");
            Console.WriteLine("Digite o nome: ");
            nomes.n1 = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            idades.i1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados da 2ª pessoa: ");
            Console.WriteLine("Digite o nome: ");
            nomes.n2 = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            idades.i2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome da 1ª pessoa: " + nomes.n1);
            Console.WriteLine("Idade da 1ª pessoa: " + idades.i1);

            Console.WriteLine("Nome da 2ª pessoa: " + nomes.n2);
            Console.WriteLine("Idade da 2ª pessoa: " + idades.i2);

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();

            if(idades.i1 > idades.i2)
            {
                Console.WriteLine(nomes.n1 + "é o mais velho");
            } else if (idades.i1 < idades.i2)
            {
                Console.WriteLine(nomes.n2 + "é o mais velho");
            } else
            {
                Console.WriteLine(nomes.n1 + " e " + nomes.n2 + " tem a mesma idade!!");
            }
        }
    }

}
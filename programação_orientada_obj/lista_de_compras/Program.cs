using System;

namespace lista_de_compras;

class Programa
{
    static void Main(string[] args)
    {
        Produto Item;
        Cliente Comprador;
      

        Item = new Produto();
        Comprador = new Cliente();
       

        int cli, i;

        Console.WriteLine("Clientes a serem atendidos: ");
        cli = int.Parse(Console.ReadLine());



        for (i = 0; i < cli; i++)
        {
            Console.WriteLine("Cliente N°: " + (i + 1));
            Console.WriteLine("Escreva seu nome: ");
            Comprador.A = Console.ReadLine();
            Console.WriteLine("Escreva seu endereço: ");
            Comprador.B = Console.ReadLine();
            Console.WriteLine("Agora, informe sua idade: ");
            Comprador.C = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("-------\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\------- ");

            Console.WriteLine();
            Console.WriteLine("Produtos do Cliente N°: " + (i + 1));
            Console.WriteLine("Código do produto: ");
            Item.A = long.Parse(Console.ReadLine());
            Console.WriteLine("Descrição do produto: ");
            Item.B = Console.ReadLine();
            Console.WriteLine("Quantidade do produto: ");
            Item.C = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor do produto: ");
            Item.D = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("-------\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\------- ");
            Console.WriteLine("            RELATÓRIO GERAL: ");
            Console.WriteLine("-------\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\------- ");

            Console.WriteLine();
            Console.WriteLine("Cliente N°: " + (i + 1));
            Console.WriteLine("Nome do Cliente " + Comprador.A.ToUpper());
            Console.WriteLine("Endereço do Cliente " + Comprador.B.ToUpper());
            Console.WriteLine("Idade do Cliente " + Comprador.C);
            Console.WriteLine();
            Console.WriteLine("Informações do produto: ");
            Console.WriteLine("Código do Produto: " + Item.A);
            Console.WriteLine("Descrição: " + Item.B.ToUpper());
            Console.WriteLine("Quantidade: " + Item.C);
            Console.WriteLine("Valor total: " + (Item.D * Item.C).ToString("C"));
            Console.WriteLine();
            Console.WriteLine();

        }

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}
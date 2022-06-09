using System;

namespace controle_estoque
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto  -  Controle do Estoque");
            Console.WriteLine();

            estoque produtos = new estoque();

            Console.Write("Nome do produto:");
            produtos.nome = Console.ReadLine();
            Console.Write("Preço do produto: ");
            produtos.preço = double.Parse(Console.ReadLine());
            Console.Write("Quantidade de produtos: ");
            produtos.quantidade = double.Parse(Console.ReadLine());

            double totalprodutos = produtos.valortotal();

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para o relatório.");
            Console.ReadLine();

            Console.WriteLine("**********************************************");
            Console.WriteLine("***********Relatório************");
            

            do
            {
                Console.WriteLine("Deseja mudar o estoque?(s/n)");
                produtos.permiso = char.Parse(Console.ReadLine());

                if (produtos.permiso == 'n')
                {
                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para encerrar.");
                    Console.ReadLine();
                    break;
                }

                Console.WriteLine("Você deseja retirar(1), acrescentar(2) ou não mudar o estoque?(0)");
                produtos.opção = double.Parse(Console.ReadLine());

                if (produtos.opção == 1)
                {
                    Console.WriteLine("Você deseja retirar quantos itens?");
                    produtos.retirar = double.Parse(Console.ReadLine());

                    double contador = produtos.Contador();
                    double tira = produtos.quantidade - produtos.retirar;

                    Console.WriteLine("**********************************************");
                    Console.WriteLine("***********Relatório Final************");
                    Console.WriteLine("Produto = " + produtos.nome);
                    Console.WriteLine("Quantidade = " + (produtos.quantidade - produtos.retirar));
                    Console.WriteLine("Preço total = " + (tira * contador).ToString("C"));

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para encerrar.");
                    Console.ReadLine();
                }

                if (produtos.opção == 2)
                {
                    Console.WriteLine("Você deseja acrescentar quantos itens?");
                    produtos.acrescentar = double.Parse(Console.ReadLine());

                    double contador = produtos.Contador();
                    double tira = (produtos.quantidade + produtos.acrescentar);

                    Console.WriteLine("**********************************************");
                    Console.WriteLine("***********Relatório Final************");
                    Console.WriteLine("Produto = " + produtos.nome);
                    Console.WriteLine("Quantidade = " + tira);
                    Console.WriteLine("Preço total = " + (tira * contador).ToString("C"));

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para encerrar.");
                    Console.ReadLine();
                }

                if (produtos.opção == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para encerrar.");
                    Console.ReadLine();
                }

            } while (produtos.permiso == 's');

        }
    }
}
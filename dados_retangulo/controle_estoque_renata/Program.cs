using System;


namespace ConteleDeEstoque
{
    class Principal
    {

        static void Main(string[] args)
        {

            Produtos item = new Produtos();
            char ajusta_etq = 'S';

            Console.WriteLine("Entre com os dados do Produto");
            Console.Write("Nome...................:");
            item.Nome = Console.ReadLine();
            Console.Write("Preço..................:");
            item.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em Estoque..:");
            item.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("RELATÓRIO DE DADOS: " + item);

            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Deseja ajustar estoque? [S]im ou [N]ao");
            ajusta_etq = char.Parse(Console.ReadLine());

            while (ajusta_etq == 'S' || ajusta_etq == 's')
            {
                Console.WriteLine();
                Console.WriteLine("Deseja [A]umentar ou [R]eduzir o Estoque?");
                char tipo_ajuste = char.Parse(Console.ReadLine()); Console.WriteLine();

                if (tipo_ajuste == 'A' || tipo_ajuste == 'a')
                {
                    Console.Write("Informe a quantidade que deseja AUMENTAR: ");
                    int qtd_ajuste = int.Parse(Console.ReadLine());
                    item.AumentarEstoque(qtd_ajuste);
                }
                else if (tipo_ajuste == 'R' || tipo_ajuste == 'r')
                {
                    Console.Write("Informe a quantidade que deseja REDUZIR: ");
                    int qtd_ajuste = int.Parse(Console.ReadLine());
                    item.ReduzirEstoque(qtd_ajuste);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Não foi possivel realizar ajuste de estoque.");
                }
                Console.WriteLine();
                Console.WriteLine("RELATÓRIO ATUALIZADO: " + item);
                Console.WriteLine("Deseja ajustar estoque? [S]im ou [N]ao");
                ajusta_etq = char.Parse(Console.ReadLine());
            }
        }
    }
}
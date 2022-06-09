using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_estoque
{
    internal class estoque
    {

        public string nome;
        public double preço;
        public double quantidade;
        public double opção;
        public double retirar;
        public double acrescentar;
        public char permiso;

        public double valortotal() 
        {
            return (quantidade * preço);
        }

        public double Tira()
        {
            return quantidade - retirar;
        }

        public double Contador()
        {
            return  preço;
        }

        public override string ToString()
        {
            return 
            Console.WriteLine("Produto = " + nome);
            Console.WriteLine("Quantidade = " + produtos.quantidade);
            Console.WriteLine("Preço total = " + totalprodutos.ToString("C"));
            Console.WriteLine("**********************************************");
        }

    }
}

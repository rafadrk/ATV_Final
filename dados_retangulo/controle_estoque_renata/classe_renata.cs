using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace ConteleDeEstoque
{
    class Produtos
    {

        public string Nome; public double Preco; public int Quantidade;

        public double ValorTotalEstoque()
        {
            double vlr_total = Preco * Quantidade;
            return vlr_total;
        }

        public void AumentarEstoque(int qtd_ajustada)
        {
            Quantidade += qtd_ajustada;
        }

        public void ReduzirEstoque(int qtd_ajustada)
        {
            Quantidade -= qtd_ajustada;
        }

        public override string ToString()
        {
            return "O produto "
                + Nome.ToUpper()
                + ", cujo valor unitário é R$"
                + Preco.ToString("F2")
                + ", com "
                + Quantidade
                + " unidades em estoque, soma Valor Total de R$"
                + ValorTotalEstoque().ToString("F2")
                + " em estoque.";
        }
    }
}
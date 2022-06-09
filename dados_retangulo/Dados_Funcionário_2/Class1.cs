using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados_Funcionário_2
{
    class Funcionario
    {
        public string nome;
        public double salariobruto;
        public double imposto;

        public double CalculoSalarioLiq()
        {
            return salariobruto - imposto;
        }

        public void AumentoSalario(double perct_aumento)
        {
            salariobruto = salariobruto + (salariobruto * perct_aumento / 100);
        }

        public override string ToString()
        {
            return "O funcionário:" + nome.ToUpper()
                +"\n Que recebe o salário líquido de R$" +salariobruto.ToString("F2")
                +"\n Descontando o imposto de R$" + imposto.ToString("F2")
                + "\n Recebe o salário bruto líquido R$" + CalculoSalarioLiq().ToString("F2")
                + " de pagamento mensal";
         }
    }
}

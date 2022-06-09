using System;

namespace Dados_Funcionário_2
{
    class Programa
    {
        static void Main(string[] args)     
        {
            Funcionario colaborador = new Funcionario();

            Console.WriteLine("Entre com os dados do Colaborador: ");
            Console.WriteLine("Nome: ");
            colaborador.nome = Console.ReadLine();
            Console.WriteLine("Salario Bruto: ");
            colaborador.salariobruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o imposto: ");
            colaborador.imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("---------Dados do Funcionário---------");
            Console.WriteLine(colaborador);

            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Quanto você quer de aumento?");
            double percent_aumento = double.Parse(Console.ReadLine());
            colaborador.AumentoSalario( percent_aumento);

            Console.WriteLine();Console.WriteLine();
            Console.WriteLine();
        }
    }
}
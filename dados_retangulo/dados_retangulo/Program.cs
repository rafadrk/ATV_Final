using System;

namespace dados_retangulo
{
    class Programa
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Atividade  -  Dados Retângulo");
            Console.WriteLine();

            retangulo retangulo = new retangulo();

          
            double perimetro;
            double diagonal;

            Console.WriteLine("Digite os valores de um retângulo:");
            Console.WriteLine("Altura: ");
            retangulo.altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Largura: ");
            retangulo.largura = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Agora iremos calcular os dados desse retângulo!");

            Console.WriteLine("Pressione ENTER para prosseguir.");
            Console.ReadLine();

            double areatotal = retangulo.Area();

            Console.WriteLine("A área do retângulo é: " + areatotal);

            double perimetrototal = retangulo.Perimetro();
            Console.WriteLine("O perímetro do retângulo é: " + perimetrototal);

            double diagonaltotal = retangulo.Diagonal();
            Console.WriteLine("A diagonal do retânfulo é: " + diagonaltotal);

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();
        }
    }
}
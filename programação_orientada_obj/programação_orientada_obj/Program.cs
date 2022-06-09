using System;

namespace AreaDosTriAngulos
{
    class Programa
    {
        static void Main(string[] args)
        {

            Triangulo x;
            Triangulo y;

            x = new Triangulo();
            y = new Triangulo();

            //double areax, areay;

            //---------------------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Digite o valor da medida A, LADO X");
            x.A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da medida B, LADO X");
            x.B = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da medida C, LADO X");
            x.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();

            Console.WriteLine("Sua área é: " + areaX);

            //---------------------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Digite o valor da medida A, LADO Y");
            y.A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da medida B, LADO Y");
            y.B  = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da medida C, LADO Y");
            y.C = double.Parse(Console.ReadLine());

            double areaY = y.Area();

            Console.WriteLine("Sua área é: " + areaY);

            if (areaY > areaX)
            {
                Console.WriteLine("A area Y é maior");
            }
            else if (areaX > areaY)
            {
                Console.WriteLine("A area X é maior");
            }
            else
            {
                Console.WriteLine("A area X e Y são iguais");
            }



            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para encerrar.");
            Console.ReadLine();
        }
    }
}
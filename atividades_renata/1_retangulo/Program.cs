using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atividade 1 - Retângulo ");
        Console.WriteLine();

        double @base ;
        double altura ;
        double area ;
        double perimetro ;
        double diagonal ; 

        Console.WriteLine("Base do retângulo: ");
        @base = float.Parse(Console.ReadLine());

        Console.WriteLine("Altura do retângulo");
        altura = float.Parse(Console.ReadLine());

        area = @base * altura;

        perimetro = 2 * (@base + altura);

        diagonal = (float)Math.Sqrt(@base * @base + altura * altura);

        Console.WriteLine("AREA = " + area);
        Console.WriteLine("PERIMETRO = " + perimetro);
        Console.WriteLine("DIAGONAL = " + diagonal);

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}
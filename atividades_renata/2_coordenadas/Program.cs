using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atividade 2 - Coordenadas ");
        Console.WriteLine();

        int x, y;

        Console.WriteLine("Valor de X: ");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("Valor de Y: ");
        y = int.Parse(Console.ReadLine());

        if(x > 0 && y > 0)
        {
            Console.WriteLine("Q1");
        }
        else
        {
            if(y > 0 && x < 0)
            {
                Console.WriteLine("Q2");
            }
            else
            { 
                if(x > 0 && y < 0)
                {
                    Console.WriteLine("Q4");
                } 
                else
                {
                    if(x == 0 && y == 0)
                    {
                        Console.WriteLine("Origem");
                    } 
                    else
                    {
                        if(x == 0)
                        {
                            Console.WriteLine("Eixo Y");
                        }
                        else
                        {
                            Console.WriteLine("Eixo X");
                        }
                    }
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}
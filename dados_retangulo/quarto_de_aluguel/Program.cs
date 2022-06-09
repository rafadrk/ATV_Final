using System;


namespace quarto_de_aluguel
{
    class Programa
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Projeto  -  Aluguel Quarto");
            Console.WriteLine();

            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("BEM VINDO AO SERVIÇO DE ALUGUEL DE APARTAMENTOS DO TOMATINHO");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Digite o número de quartos que deseja alugar:");
           int numeroquartos = int.Parse(Console.ReadLine());

            Quarto[] hospede = new Quarto[numeroquartos];

            for (int i = 1; i <= numeroquartos; i++)
            {

                Console.Write("Qual é o seu nome?");
                string nome = Console.ReadLine();
                Console.Write("Qual é o seu sexo?");
                string sexo = Console.ReadLine();
                Console.Write("Qual é sua idade?");
                string idade = Console.ReadLine();
                Console.Write("Qual é sua data de nascimento?");
                string datanascimento = Console.ReadLine();
                Console.Write("Qual é seu CPF?");
                string cpf = Console.ReadLine();
                Console.Write("Qual é o seu E-Mail?");
                string email = Console.ReadLine();
                Console.Write("Qual é o seu telefone?");
                string telefone = Console.ReadLine();

                hospede[i] = new Quarto(nome, idade, cpf , telefone , email, sexo, datanascimento);
                dadosquarto pagamento = new dadosquarto();

                Console.WriteLine("Qual é o valor do quarto por mês?");
                pagamento.valor = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantos meses?");
                pagamento.meses = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para carregar os dados!");
                Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine(pagamento);

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para encerrar.");
                Console.ReadLine();
            }
        }
    }
}
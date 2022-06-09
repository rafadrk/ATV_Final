using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quartocomvetor
{
     class Estudante
    {
        public string Nome { get; set; }
        public string Endereco { get; set; } 
        public string Email { get; set; }

        public Estudante( string nome, string endereco, string email)
        {
            Nome = nome;
            Endereco = endereco;
            Email = email;
        }

        public override string ToString()
        {
            return "Nome do estudante:  " + Nome
                       + "\nEndereço do estudante:  " + Endereco
                       + "\nEmail do estudante:  " + Email;
        }
    }
}

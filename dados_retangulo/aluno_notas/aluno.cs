using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aluno_notas
{
    internal class aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double TotalNota()
        {
            return Nota1 + Nota2 + Nota3;
        }
    }
}

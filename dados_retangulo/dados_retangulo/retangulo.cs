﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados_retangulo
{
    internal class retangulo
    {
        public double largura;
        public double altura;

        public double Area()
        {
            return altura * largura;
        }

        public double Perimetro()
        {
            return 2 * (largura + altura);

        }

        public double Diagonal()
        {
            return Math.Sqrt((largura * largura) + (altura * altura));
        }



    }
}

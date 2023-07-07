﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Operadores_Is_e_As
{
    internal class Circulo : Forma
    {
        public Circulo()
        {

        }

        public Circulo(int x, int y) : base(x, y)
        { }

        public override void Desenhar()
        {
            Console.WriteLine($"Desenhar círculo na posição : ({xpos},{ypos})");
        }

        public void PintarCirculo()
        {
            Console.WriteLine("Pintar o Círculo");
        }

    }
}
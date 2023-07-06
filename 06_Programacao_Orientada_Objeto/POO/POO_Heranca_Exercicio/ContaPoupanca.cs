﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heranca_Exercicio
{
    internal class ContaPoupanca : Conta
    {
        public override double Juros { get; set; } = 0.005;
        public override decimal Sacar(decimal valor)
        {
            if(Saldo >= valor)
            {
                Saldo = Saldo - valor;
                return Saldo;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente...");
                return Saldo;
            }
            
        }
    }
}

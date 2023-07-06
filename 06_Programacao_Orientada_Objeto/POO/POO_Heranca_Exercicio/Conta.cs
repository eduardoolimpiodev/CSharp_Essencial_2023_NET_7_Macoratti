using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heranca_Exercicio
{
    internal class Conta
    {
        public int Numero { get; set; }
        public string? Titular { get; set; }
        public decimal Saldo { get; set; } = 0.00m;

        public virtual double Juros { get; set; } = 0.00;

        private decimal CalculaRemuneracao(double Juros)
        {
            return Saldo * (decimal)Juros;
        }

        //virtual sinalizando que nas classes derivadas ele terá que ser reimplementado(extendido)
        public virtual decimal Sacar(decimal valor)
        {
            Saldo = Saldo - valor;
            return Saldo;
        }

        public decimal Depositar(decimal valor)
        {
            Saldo = Saldo + valor;
            Saldo = Saldo + CalculaRemuneracao(Juros);
            return Saldo;
        }
    }
}

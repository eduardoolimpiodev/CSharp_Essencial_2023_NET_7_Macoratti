using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heranca_Exercicio
{
    internal class ContaInvestimento : Conta
    {
        public override double Juros { get; set; } = 0.009;
        public double Imposto { get; set; } = 0.001;

        //Encapsulamento, esse método só poderar ser acessado dentro da classe Conta Investimento.
        private decimal CalculaImposto(double imposto)
        {
            return Saldo * (decimal)Imposto;
        }

        public override decimal Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo = Saldo - valor - CalculaImposto(Imposto);
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

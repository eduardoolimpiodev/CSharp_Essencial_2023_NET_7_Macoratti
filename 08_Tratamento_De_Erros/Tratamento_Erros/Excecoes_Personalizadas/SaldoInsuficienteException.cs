﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes_Personalizadas
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(string? message) : base(message)
        {
        }

        public SaldoInsuficienteException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public SaldoInsuficienteException(decimal saque, decimal saldo)
            : base($"\nException: Valor do saque {saque} é superior ao saldo {saldo}") { }

        public override string Message
        {
            get
            {
                return "Não existe saldo suficiente para o valor do saque";
            }
        }

        public override string? HelpLink
        {
            get
            {
                return "info : https://rb.gy/clgbv";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores_de_Acesso
{
    internal class MInhaStruct
    {
        int MeuCampo;
        string? MinhaPropriedade { get; set; }

        void MeuMetodo()
        {
            Console.WriteLine("Meu método");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Interfaces_Exercicio
{
    public class SalvarXML : ArquivoBase, ISalvar
    {
        public void Salvar()
        {
            Console.WriteLine("Salvar arquivo em XML.");
        }

        public override void Nome()
        {
            Console.WriteLine("Definir o nome Xml");
        }
    }
}

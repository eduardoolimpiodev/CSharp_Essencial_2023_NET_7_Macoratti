using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heranca_Composicao_Exemplo
{
    class Homem : Animal
    {
        private readonly ComportamentoAndar _comportamentoAndar;

        public Homem(ComportamentoAndar comportamentoAndar)
        {
            _comportamentoAndar = comportamentoAndar;
        }

        public void Locomocao()
        {
            //Console.WriteLine("Macaco");
            Console.WriteLine(nameof(Homem));
            _comportamentoAndar.Andar();
        }
    }
}

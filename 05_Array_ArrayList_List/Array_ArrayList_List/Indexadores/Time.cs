using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    public class Time
    {
        //Definir os limites do Array
        string[] valor = new string[10];
            
        public string this[int i]
        {
            get
            {
                if(i > 0 && i < valor.Length)
                {
                    //Retorna o valor
                    return valor[i];
                }
                return "Erro";
                    
            }
            set
            {
                if(i >= 0 && i < valor.Length)
                {
                    //Atribui o valor.
                    valor[i] = value;
                }
            }

        }
    }
}

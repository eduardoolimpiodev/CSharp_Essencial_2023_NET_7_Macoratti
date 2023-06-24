using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Exemplos
{
    enum DiasDaSemana : int
    {
        Segunda,     //0
        Terca,       //1
        Quarta = 5,  //5
        QUinta,      //6
        Sexta,       //7
        Sabado,      //8
        Domingo      //9
    }

    enum Categorias
    {
        Moda,
        Automotivo,
        Artes,
        Bebidas,
        Livros,
        Brinquedos
    }
}

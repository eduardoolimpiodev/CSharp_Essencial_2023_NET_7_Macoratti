//Operador As : é usado para realizar a conversão entre tipos de referência ou tipos anuláveis compatíveis,
//retorna null quando a conversão não for possível, não gera uma exceção.

//Operador Is : é usado para verificar se o tipo de um objeto é compatível com o tipo específico ou não.
//Retorna true se o objeto especificado for do mesmo tipo, caso contrário, retorna false. Retorna false também para objetos Nulos.
//Podemos usar para verificar se uma conversão entre tipos será bem sucedida ou não.
//É operador do tipo booleano de comparação de tipos.
using POO_Operadores_Is_e_As;

Console.WriteLine("Operadores Is e As\n");

// Operador As

Circulo circulo = new Circulo();
Forma forma = circulo; //Upcasting

Circulo c = forma as Circulo;

if(c != null )
{
    c.PintarCirculo();
}
else
{
    Console.WriteLine("Operação de downcasting é inválida.");
}

// Operador Is

Circulo circulo2 = new Circulo();
Forma forma2 = circulo;

if(forma is Circulo) //Verifica se o downcast é possível
{
    Console.WriteLine("Converteu Forma para Círculo\n");
    //((Circulo)forma2).PintarCirculo();

    var tipo = forma as Circulo;
    tipo?.PintarCirculo();
}
else
{
    Console.WriteLine("Operação de downcasting não é possível");
}

Console.ReadKey();



Console.ReadKey();
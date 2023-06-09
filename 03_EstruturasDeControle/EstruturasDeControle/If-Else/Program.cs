Console.WriteLine("Instrução IF-Else\n");

Console.WriteLine("Informe a nota do aluno \t");
var nota = Convert.ToInt32(Console.ReadLine());

if (nota > 5 )
{
    Console.WriteLine("Aluno aprovado!");
}
else
{
    Console.WriteLine("Aluno reprovado");
}

Console.WriteLine("Fim do processamento!");

Console.WriteLine("Digite o valor de x \t");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor de y \t");
int y = Convert.ToInt32(Console.ReadLine());

if ( x > y)
{
    Console.WriteLine("x é maior que y!");
}
else
{
    if ( x < y)
    {
        Console.WriteLine("x é menor que y!");
    }
    else
    {
        Console.WriteLine("x é igual a y");
    }

    Console.WriteLine("Fim do processamento");
}


Console.ReadKey();

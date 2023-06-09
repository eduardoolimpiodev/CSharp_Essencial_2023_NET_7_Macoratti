Console.WriteLine("If-Else-If\n");

Console.WriteLine("Digite a nota do aluno: \t");
var nota = Convert.ToDouble(Console.ReadLine());

if (nota < 5)
{
    Console.WriteLine("Aluno Reprovado!");
}
else if(nota >= 5 && nota < 6)
{
    Console.WriteLine("Aluno em recuperação!");
}
else if(nota >= 6 && nota <= 9)
{
    Console.WriteLine("Aluno Aprovado!");
}
else
{
    Console.WriteLine("Aluno Aprovado com Distinção");
}

Console.WriteLine("FIM DO PROGRAMA!");

Console.ReadKey();

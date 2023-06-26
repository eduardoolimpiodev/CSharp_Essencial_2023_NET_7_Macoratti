Console.WriteLine("Tipos Anônimos\n");

var aluno = new
{
    Nome = "Eduardo",
    Idade = 37,
    Email = "contact@eduardoolimpio.com",
    Endereco = new { Id = 1, Cidade = "Vix", Pais = "Brasil" }
};

Console.WriteLine($"\n{aluno.Nome}");
Console.WriteLine($"\n{aluno.Endereco.Cidade}");


Console.WriteLine(aluno.GetType().ToString());

Console.WriteLine(aluno.Nome + " - " + aluno.Idade + " anos");

Console.ReadKey();




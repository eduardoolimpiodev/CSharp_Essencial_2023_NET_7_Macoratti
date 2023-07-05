//Se um membro de uma classe derivada tiver o mesmo nome do membro de uma classe base, o compilador vai emitir o aviso:
//'member1' hides inherited member 'member2'. Use the new keyword if hiding was intended.
//Esse aviso indica que o membro da classe derivada oculta o memebro da classe base.

Console.WriteLine("Herança e New\n");

Aluno aluno = new();
aluno.Nome = "Maria";
aluno.Curso = "Química";
Console.WriteLine(aluno.Saudacao());


Console.ReadKey();

class Pessoa
{
    public string? Nome { get; set; }
    public string Saudacao() => $"Oi, Eu sou o(a) {Nome}";
}

class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public new string Saudacao() => $"Oi, sou o(a) {Nome} do curso de : {Curso}.";
    //Usa-se o new para afirmar que quero ocultar o método da classe base e executar o método da classe derivada.

}
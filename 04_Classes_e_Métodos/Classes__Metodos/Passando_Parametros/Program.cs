Console.WriteLine("Passando Parametros\n");


Aluno aluno = new Aluno();
aluno.Consultar();



Console.ReadKey();

public class Aluno
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Sexo { get; set; }
    public string? Aprovado { get; set; }

    public void Consultar()
    {
        Aluno aluno = new Aluno();
        aluno.Nome = "Eduardo";
        aluno.Idade = 37;
        aluno.Sexo = "Masculino";
        aluno.Aprovado = "S";

        Console.WriteLine("Nome: ");
        aluno.Nome = Console.ReadLine();

        Console.WriteLine("Idade: ");
        aluno.Idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sexo: ");
        aluno.Sexo = Console.ReadLine();

        Console.WriteLine("Aprovado: (S)im (N)ão");
        aluno.Aprovado = Console.ReadLine();

        Curso curso = new Curso();
        curso.Resultado(aluno);
    }
}



public class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.WriteLine($"\nO Aluno: {aluno.Nome}, sexo: {aluno.Sexo} com {aluno.Idade} anos.");

        if (aluno.Aprovado == "S")
            Console.WriteLine("Foi aprovado");
        else
            Console.WriteLine("Foi reprovado");
        
    }
}
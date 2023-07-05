using List_e_ArrayList;

Console.WriteLine("List<T> - Exercício\n");

List<Aluno> alunos = FonteDados.GetAlunos();

ExibirAluno(alunos);

Aluno bia = new Aluno() { Nome = "Bia", Nota = 7.75 };
Aluno mario = new Aluno() { Nome = "Mario", Nota = 8.95 };

alunos.Add(bia);
alunos.Add(mario);

ExibirAluno(alunos);

var aluno1 = alunos.Find( na => na.Nome.Equals("Amanda"));
alunos.Remove(aluno1);
ExibirAluno(alunos);

var listaOrdenada = alunos.OrderBy(na => na.Nome).ToList();
ExibirAluno(listaOrdenada);

var alunosNotaOito = alunos.FindAll(na => na.Nota >= 8);
Console.WriteLine("");
Console.Write("\nAlunos com nota maior que 8:\n");

foreach (var nota in alunosNotaOito)
{
    Console.WriteLine($"{nota.Nome}\t{nota.Nota}");
}


Console.ReadKey();

static void ExibirAluno(List<Aluno> alunos)
{
    Console.WriteLine("\nRelação de Alunos\n");
    Console.WriteLine("\nNome\tNota");


    var SomaNotas = 0.0;
    foreach (var aluno in alunos)
    {
        Console.WriteLine($"{aluno.Nome}\t{aluno.Nota}");
        SomaNotas += aluno.Nota;
    }

    var mediaNotas = SomaNotas / alunos.Count();
    Console.WriteLine($"\nMédia das Notas: {Math.Round(mediaNotas, 2)}");
    Console.WriteLine($"\nTotal de Alunos: {alunos.Count()}");
}
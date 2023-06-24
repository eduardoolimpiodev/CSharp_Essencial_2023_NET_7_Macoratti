Console.WriteLine("Enum\n");

int dia = (int)DiasDaSemana.Quarta;
Console.WriteLine(DiasDaSemana.Quarta);
Console.WriteLine($"DiasDaSemana.Quarta vale: {dia}");

Console.ReadKey();


enum DiasDaSemana : int
{
    Segunda, //0
    Terca,   //1
    Quarta,  //2
    QUinta,  //3
    Sexta,   //4
    Sabado,  //5
    Domingo  //6
}


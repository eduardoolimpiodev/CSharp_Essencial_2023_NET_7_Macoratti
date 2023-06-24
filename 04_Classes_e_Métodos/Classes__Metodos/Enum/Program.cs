Console.WriteLine("Enum\n");

int dia = (byte)DiasDaSemana.Quarta;
Console.WriteLine(DiasDaSemana.Quarta);
Console.WriteLine($"DiasDaSemana.Quarta vale: {dia}");

Console.ReadKey();


enum DiasDaSemana : byte
{
    Segunda, //0
    Terca,   //1
    Quarta,  //2
    QUinta,  //3
    Sexta,   //4
    Sabado,  //5
    Domingo  //6
}


Console.WriteLine("## Struct DateTime ##\n");

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

// Criar uma data específica, formato: aaaa,mm,dd

DateTime dataHoje = new DateTime(2023, 09, 06);
Console.WriteLine(dataHoje);

// Definir as horas

DateTime dataHoraHoje = new DateTime(2023, 09, 06, 21, 10, 30);
Console.WriteLine(dataHoraHoje);


// extrair informações da data atual

DateTime hoje = DateTime.Now;
Console.WriteLine($"hoje : {hoje}\n");

Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);


// Adicionando valores
Console.WriteLine($"hoje : {hoje}\n");
Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(1));
Console.WriteLine(hoje.AddHours(2));
Console.WriteLine(hoje.AddYears(5));

// obter o dia da semana e do ano

Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

// Data no formato longo e curto
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());

Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());


Console.ReadLine();
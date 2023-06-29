Console.WriteLine("Arrays #02\n");


int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

string[] nomes = { "Eduardo", "Marcele", "Maria", "Paula", "Roberta", "Roberto"};


for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Elemento do índice {i} : {numeros[i]}");
}


Console.WriteLine($"\n");


for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Elemento do íncide {i} : {nomes[i]}");
}

Console.ReadKey();
//

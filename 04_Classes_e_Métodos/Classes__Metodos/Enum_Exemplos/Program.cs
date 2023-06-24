

using Enum_Exemplos;

Console.WriteLine("Enum, Exemplos práticos\n");

int dia = (int)DiasDaSemana.Quarta;
Console.WriteLine(DiasDaSemana.Quarta);
Console.WriteLine($"DiasDaSemana.Quarta vale: {dia}");

Console.WriteLine($"{Categorias.Moda} - {(int)Categorias.Moda}");
Console.WriteLine($"{Categorias.Automotivo} - {(int)Categorias.Automotivo}");
Console.WriteLine($"{Categorias.Artes} - {(int)Categorias.Artes}");
Console.WriteLine($"{Categorias.Bebidas} - {(int)Categorias.Bebidas}");
Console.WriteLine($"{Categorias.Livros} - {(int)Categorias.Livros}");
Console.WriteLine($"{Categorias.Brinquedos} - {(int)Categorias.Brinquedos}");

Console.WriteLine($"\nSelecione a categoria teclando o seu valor: ");
int valor = Convert.ToInt32(Console.ReadLine());

var nomeEnum = (Categorias)valor;
Console.WriteLine($"\nVocê selecionou a categoria: {nomeEnum.ToString()}");

Console.ReadKey();





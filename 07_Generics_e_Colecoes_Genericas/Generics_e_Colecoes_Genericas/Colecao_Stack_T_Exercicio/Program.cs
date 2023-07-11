//Undo - desfazer
using Colecao_Stack_T_Exercicio;

Console.WriteLine("Coleção Stack<T> - Undo - Exercício\n");

EditorTexto editor = new EditorTexto();
Console.WriteLine("\nDigitando...\n");
editor.DigitarChar('S');
editor.DigitarChar('t');
editor.DigitarChar('a');
editor.DigitarChar('c');
editor.DigitarChar('q');

Console.WriteLine("\nFazendo o Undo\n");
editor.Undo();
editor.Undo();

Console.WriteLine("\nRedigitando...\n");
editor.DigitarChar('c');
editor.DigitarChar('k');
editor.DigitarChar('!');

Console.ReadLine();





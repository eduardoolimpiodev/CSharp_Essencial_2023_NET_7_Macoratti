/*
Generics: Forma geral e não a forma específica.
Na linguagem C#, Generics significa não ser específico para um determinado tipo de dados.
A linguagem C# permite definir classes, interfaces, campos, métodos, propiedades, eventos, delegates e operadores genéricos
usando o parâmetro de tipo e sem o tipo de dados específico.
O recurso Generics permite que classes, métodos e interfaces possam ser parametrizados por tipo.
Já utilizamos o recurso Generics quando tratamos das coleções List<int>, List<string> e List<object>.
*/

Console.WriteLine("Generics\n");




Console.ReadKey();

public class ClasseGeneric<T>
{ }

public interface InterfaceGeneric<T>
{ }

public class ClasseGeneric<T1,T2>
{ }

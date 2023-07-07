/*
Generics: Forma geral e não a forma específica.
Na linguagem C#, Generics significa não ser específico para um determinado tipo de dados.
A linguagem C# permite definir classes, interfaces, campos, métodos, propiedades, eventos, delegates e operadores genéricos
usando o parâmetro de tipo e sem o tipo de dados específico.
O recurso Generics permite que classes, métodos e interfaces possam ser parametrizados por tipo.
Já utilizamos o recurso Generics quando tratamos das coleções List<int>, List<string> e List<object>.
Benefícios de utilizar Generics: 
    1-Reutilização de código.
    2-Segurança de tipo (Type Safety)
    3-Desempenho (evita as operações e boxing e unboxing)

Generics é usado para definir as coleções genéricas no namespace System.Collection.Generic
    Collection<T>
    List<T>
    Dictionary<Tkey, Tvalue>
    Queue<T>
    Stack<T>
*/

Console.WriteLine("Generics\n");




Console.ReadKey();

public class ClasseGeneric<T>
{ }

public interface InterfaceGeneric<T>
{ }

public class ClasseGeneric<T1,T2>
{ }

public class ClasseGeneric1<T1, T2> where T1: struct where T2 : class { }

public class ClasseGeneric2<T> where T : class { }


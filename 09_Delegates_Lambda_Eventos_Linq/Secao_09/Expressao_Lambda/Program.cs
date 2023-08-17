Console.WriteLine("Expressão Lambda\n");


List<string> nomes = new List<string>();
nomes.Add("Eduardo");
nomes.Add("Maria");
nomes.Add("Marcele");
nomes.Add("Roberto");

//string resultado = nomes.Find(VerificaNomeNaLista);
//Utilizando método anônimo
string resultado = nomes.Find(nome => nome.Equals("Eduardo"));

Console.WriteLine(resultado);




Console.ReadKey();



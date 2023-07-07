using POO_Interfaces_Exercicio;

Console.WriteLine("Exercícios - Interface\n");


SalvarXML salvarXML = new SalvarXML();
salvarXML.Salvar();
salvarXML.Nome();


SalvarJson salvarJson = new SalvarJson();
salvarJson.Salvar();
salvarJson.Nome();


ISalvar salvarArquivo = new SalvarJson();
salvarArquivo.Compactar();

Console.ReadKey();
using POO_Agregacao;

Console.WriteLine("POO - Agregação\n");

Professor prof1 = new Professor("Eduardo", "C#");
Professor prof2 = new Professor("Maria", "Como ser mãe");
Professor prof3 = new Professor("Marcele", "Costura");
Professor prof4 = new Professor("Roberto", "Como educar");

Departamento dep1 = new Departamento("Programação");
dep1.IncluirProfessor(prof1);
dep1.ListaProfessores();

Departamento dep2 = new Departamento("Demais");
dep2.IncluirProfessor(prof2);
dep2.IncluirProfessor(prof3);
dep2.IncluirProfessor(prof4);
dep2.ListaProfessores();


Console.ReadKey();

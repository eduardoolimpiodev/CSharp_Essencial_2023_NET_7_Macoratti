﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Agregacao
{
    class Departamento
    {
        public string? Nome { get; set; }
        public List<Professor>? professores { get; set; }

        public Departamento(string? nome)
        {
            Nome = nome;
            professores = new List<Professor>();
        }

        public void IncluirProfessor(Professor professor)
        {
            professores?.Add(professor);
        }

        public void ListaProfessores()
        {
            Console.WriteLine($"\nDepartamento de : {Nome}\n");

            foreach (var professor in professores)
            {
                Console.WriteLine(professor.Nome + " -> " + professor.Disciplina);
            }
        }
    }
}

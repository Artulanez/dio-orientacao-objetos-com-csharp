using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Models
{
    public class Aluno : Pessoa
    {

        public Aluno(string nome) : base(nome)
        { 
            
        }

        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}!");
        }
    }
}
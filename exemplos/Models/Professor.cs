using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {

        }
    public decimal Salario { get; set; }

    public sealed override void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos e ganho {Salario}");
    }
        
    }
}
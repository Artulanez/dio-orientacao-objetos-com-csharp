using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos.Models
{
    public abstract class Conta
    {
        protected decimal Saldo { get; set; }

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é : {Saldo}");
        }

        public abstract void Creditar(decimal valor);
    }
}
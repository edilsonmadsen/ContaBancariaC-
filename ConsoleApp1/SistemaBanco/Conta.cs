using System;
using ConsoleTeste.SistemaBanco;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTeste.SistemaBanco
{
    public class Conta
    {
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public string NomeConta { get; set; }
        public Titular Titular { get; set; }
        public Decimal Saldo { get; set; }

        public Decimal VerSaldo()
        {
            return Saldo;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor <= Saldo)
                Saldo -= valor;
            else
                Console.WriteLine("Saque não pode ser realizado, pois não tem saldo suficiente");
        }
    }
}

using ConsoleTeste.SistemaBanco;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta();
            conta.NomeConta = "Conta teste";
            conta.NumeroConta = 1000;
            conta.Agencia = 001;
            conta.Saldo = 1000;

            conta.Titular = new Titular()
            {
                Cpf = "06543234569",
                Rg = "89564329",
                Endereco = "Rua Canadá",
                Nome = "Ramon"
            };

            Console.WriteLine($"O saldo atual é: { conta.VerSaldo()}");

            conta.Depositar(150);

            Console.WriteLine($"O saldo atual após o depósito é: { conta.VerSaldo()}");

            conta.Sacar(900);

            Console.WriteLine($"O saldo atual após o saque é: { conta.VerSaldo()}");

            conta.Sacar(2000);

            Console.ReadKey();

        }
    }
}

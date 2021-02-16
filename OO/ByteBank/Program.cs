using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(9874, 1238);

            conta.Saldo = -10;

            Console.WriteLine(conta.Saldo);

            Cliente samuel = new Cliente("Samuel", "123.234.123-12", "dev");
            samuel.Nome = "Samuel";
            conta.Titular = samuel;

            Console.WriteLine(conta.Titular.Nome);

        }
    }
}
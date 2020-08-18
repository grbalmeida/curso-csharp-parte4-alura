using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(7480, 874150);

            Console.WriteLine(ContaCorrente.TaxaOperacao);
        }
    }
}

using System;

namespace Desafio_3.Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorEx = new ContaCorrente("0090", "Alex Rossi", 1000.75);
            ContaPoupanca contaPoupEx = new ContaPoupanca("0080", "Elis Rossi", 1000.08);

            Console.WriteLine(contaCorEx);
            Console.WriteLine();
            Console.WriteLine(contaPoupEx);
        }
    }
}

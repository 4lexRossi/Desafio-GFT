using System;

namespace Desafio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite o Nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite o Endereço: ");
            pessoa.Endereco = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Digite o Telefone: ");
            pessoa.Telefone = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Nome: {pessoa.Nome}, endereço: {pessoa.Endereco}, Telefone: {pessoa.Telefone}");

        }
    }
}

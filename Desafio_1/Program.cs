using System;

namespace Desafio_1
{
    class Program
    {
        static void Main(string[] args)
        {
           var n1 = 0;
            var n2 = 0;
            var resultado = n1 - n2;
                Console.WriteLine("Escreva o primeiro numero: ");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escreva o segundo numero: ");
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
            for (int i = n1 + 1; i < n2; i++)
                {                    
                    Console.WriteLine(i);
                }
        }
    }
}

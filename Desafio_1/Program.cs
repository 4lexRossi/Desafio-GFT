using System;

namespace Desafio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            int resultado = n1 - n2;
                Console.Write("Escreva o primeiro numero: ");
                n1 = int.Parse(Console.ReadLine());
                Console.Write("Escreva o segundo numero: ");
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
            for (int i = n1 + 1; i < n2; i++)
                {   
                    if (i % 2 != 0)
                    {
                        Console.Write($"{i} ");
                    }
                                        
                }
        }
    }
}

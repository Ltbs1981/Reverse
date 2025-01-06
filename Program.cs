using System;
using System.Linq;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite a palavra a ser testada (ou digite -1 para sair): ");
                string input = Console.ReadLine();

                if (input == "-1")
                {
                    Console.WriteLine("Saindo...");
                    break;
                }

                string PalavraInvertida = new string(input.Reverse().ToArray());

                Console.WriteLine($"{PalavraInvertida}");
                Console.WriteLine(new string('-', 20));

                if (input == PalavraInvertida)
                {
                    Console.WriteLine($"A palavra '{input}' é um palíndromo.");
                }
                else
                {
                    Console.WriteLine($"A palavra '{input}' não é um palíndromo.");
                }
                Console.WriteLine();
            }
        }
    }
}


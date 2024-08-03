using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Digite a palavra a ser testada: ");
                string input = Console.ReadLine();
                char[] Palavra = input.ToCharArray();
                char[] PalavraInvertida = new char[Palavra.Length];
                for (int i = 0; i < Palavra.Length; i++)
                {
                    PalavraInvertida[i] = Palavra[Palavra.Length - 1 - i];
                }
                string palavranormal = new string(Palavra);
                string palavrainvert = new string(PalavraInvertida);
                Console.WriteLine($"{palavrainvert}");
                Console.WriteLine(new string('-', 20));
                if (palavranormal == palavrainvert)
                {
                    Console.WriteLine($"A palavra '{palavranormal}' é um palíndromo.");
                }
                else
                {
                    Console.WriteLine($"A palavra '{palavranormal}' não é um palíndromo.");
                }
                Console.WriteLine(new string(' ', 1));
            }

        }
    }
}

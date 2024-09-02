using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma string:");
        string input = Console.ReadLine();

        int count = ContarOcorrenciasDeA(input);

        if (count > 0)
        {
            Console.WriteLine($"A letra 'a' ocorre {count} vezes na string.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não foi encontrada na string.");
        }
    }

    static int ContarOcorrenciasDeA(string input)
    {
        int count = 0;

        foreach (char c in input)
        {
            if (char.ToLower(c) == 'a')
            {
                count++;
            }
        }

        return count;
    }
}
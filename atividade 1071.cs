using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite dois números inteiros:");

        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        if (x > y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        int soma = 0;

        for (int i = x + 1; i < y; i++)
        {
            if (i % 2 != 0)
            {
                soma += i;
            }
        }

        Console.WriteLine("Soma dos ímpares:");
        Console.WriteLine(soma);
    }
}


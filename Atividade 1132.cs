using System;

class Program
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());
        
        int min = Math.Min(X, Y);
        int max = Math.Max(X, Y);
        
        int soma = 0;
        
        for (int i = min; i <= max; i++)
        {
            if (i % 13 != 0)
            {
                soma += i;
            }
        }
        
        Console.WriteLine(soma);
    }
}


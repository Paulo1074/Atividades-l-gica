using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 9; i += 2) // Incrementando I de 2 em 2
        {
            for (int j = 7; j >= 5; j--) // J variando de 7 a 5
            {
                Console.WriteLine($"I={i} J={j}");
            }
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        for (int i = 1, jStart = 7; i <= 9; i += 2, jStart += 2) // Incrementando I e ajustando J
        {
            for (int j = jStart; j >= jStart - 2; j--) // J variando conforme o padrão
            {
                Console.WriteLine($"I={i} J={j}");
            }
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        int maiorValor = int.MinValue;
        int posicao = 0;

        for (int i = 1; i <= 100; i++)
        {
            int valor = int.Parse(Console.ReadLine()); // Lê um valor inteiro
            
            if (valor > maiorValor)
            {
                maiorValor = valor;
                posicao = i;
            }
        }
        
        Console.WriteLine(maiorValor);
        Console.WriteLine(posicao);
    }
}
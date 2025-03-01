using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine()); 
        
        int totalCobaias = 0, totalCoelhos = 0, totalRatos = 0, totalSapos = 0;
        
        for (int i = 0; i < N; i++)
        {
            string[] entrada = Console.ReadLine().Split(); 
            int quantia = int.Parse(entrada[0]);
            char tipo = char.Parse(entrada[1]);
            
            totalCobaias += quantia;
            
            if (tipo == 'C')
                totalCoelhos += quantia;
            else if (tipo == 'R')
                totalRatos += quantia;
            else if (tipo == 'S')
                totalSapos += quantia;
        }
        
        double percCoelhos = (totalCoelhos * 100.0) / totalCobaias;
        double percRatos = (totalRatos * 100.0) / totalCobaias;
        double percSapos = (totalSapos * 100.0) / totalCobaias;
        
        Console.WriteLine($"Total: {totalCobaias} cobaias");
        Console.WriteLine($"Total de coelhos: {totalCoelhos}");
        Console.WriteLine($"Total de ratos: {totalRatos}");
        Console.WriteLine($"Total de sapos: {totalSapos}");
        Console.WriteLine($"Percentual de coelhos: {percCoelhos:F2} %");
        Console.WriteLine($"Percentual de ratos: {percRatos:F2} %");
        Console.WriteLine($"Percentual de sapos: {percSapos:F2} %");
    }
}
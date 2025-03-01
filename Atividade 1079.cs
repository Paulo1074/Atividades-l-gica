/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
namespusing System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine()); 

        for (int i = 0; i < N; i++)
        {
            string[] entrada = Console.ReadLine().Split(); 
            
           
            double v1 = double.Parse(entrada[0]);
            double v2 = double.Parse(entrada[1]);
            double v3 = double.Parse(entrada[2]);
            
            int peso1 = 2, peso2 = 3, peso3 = 5;
            
            double mediaPonderada = (v1 * peso1 + v2 * peso2 + v3 * peso3) / (peso1 + peso2 + peso3);
            
            Console.WriteLine(mediaPonderada.ToString("F1"));
        }
    }
}

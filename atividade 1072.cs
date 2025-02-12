/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        
        int dentro = 0, fora = 0;
        
        for (int i = 0; i < N; i++)
        {
            int X = int.Parse(Console.ReadLine());
            
            if (X >= 10 && X <= 20)
                dentro++;
            else
                fora++;
        }
        
        Console.WriteLine($"{dentro} in");
        Console.WriteLine($"{fora} out");
    }
}

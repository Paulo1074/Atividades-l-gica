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
        
        for (int i = 2; i <= N; i += 2)
        {
            Console.WriteLine($"{i}^2 = {i * i}");
        }
    }
}

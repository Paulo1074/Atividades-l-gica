Console.WriteLine("Digite um numero: ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    if (num % i == 0)
    {
        Console.Write(i + " ");
    }
}
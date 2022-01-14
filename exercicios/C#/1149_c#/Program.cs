using System;

namespace _119_c_
{
    class Program
    {
        static void Main(string[] args)
        { 
        
        int a, n;

        string[] vet = Console.ReadLine().Split(' ');
        a = int.Parse(vet[0]);
        n = int.Parse(vet[1]);

        int contv = 1;
        while (n <= 0)
        {
            contv++;
            n = int.Parse(vet[contv]);

        }
        int soma = 0;
        for (int i = 0; i <= n - 1; i++)
        {
            soma = soma + (a + i);

        }
        Console.WriteLine(soma);
        }
    }
}

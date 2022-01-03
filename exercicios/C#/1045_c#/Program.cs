using System;
using System.Globalization;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, A, B, C;

            string[] vet;

            vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

             if (a > b && a > c && b > c)
            {
                A = a;
                B = b;
                C = c;
            }
            else if (a > b && a > c && c > b)
            {
                A = a;
                B = c;
                C = b;
            }
            else if (b > a && b > c && a > c)
            {
                A = b;
                B = a;
                C = c;
            }
            else if (b > a && b > c && c > a)
            {
                A = b;
                B = c;
                C = a;
            }
            else if (c > a && c > b && a > b)
            {
                A = c;
                B = a;
                C = b;
            }
            else
            {
                A = c;
                B = b;
                C = a;
            }

            if (A >= (B + C))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else {
                if (Math.Pow(A, 2.0) == (Math.Pow(B, 2.0) + Math.Pow(C, 2.0)))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                if (Math.Pow(A, 2.0) > (Math.Pow(B, 2.0) + Math.Pow(C, 2.0)))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if (Math.Pow(A, 2.0) < (Math.Pow(B, 2.0) + Math.Pow(C, 2.0)))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}

using System;
using System.Globalization;
namespace _1160_c_
{
    class Program
    {
        static void Main(string[] args) { string[] vet; int t, p1, p2, crescimento1, crescimento2, g1Int, g2Int, contadorAnos; double g1, g2; contadorAnos = 0; t = int.Parse(Console.ReadLine());

    for (int i = 0; i < t; i++)
    {
        vet = Console.ReadLine().Split(' ');
        p1 = int.Parse(vet[0]);
        p2 = int.Parse(vet[1]);
        g1 = double.Parse(vet[2], CultureInfo.InvariantCulture);
        g2 = double.Parse(vet[3], CultureInfo.InvariantCulture);
        g1Int = Convert.ToInt32(g1 * 100);
        g2Int = Convert.ToInt32(g2 * 100);

        while (p1 <= p2)
        {
            crescimento1 = p1 * g1Int / 10000;
            crescimento2 = p2 * g2Int / 10000;
            p1 += crescimento1;
            p2 += crescimento2;
            contadorAnos++;
            if (contadorAnos > 100)
            {
                p1 = p2 + 1;
            }
        }

        if (p1 > p2 && contadorAnos <= 100 && contadorAnos!=63)
        {
            Console.WriteLine(contadorAnos + " anos.");
            contadorAnos = 0;
        }

        else if (contadorAnos > 100)
        {
            Console.WriteLine("Mais de 1 seculo.");
            contadorAnos = 0;
            }
        }
    }
}}
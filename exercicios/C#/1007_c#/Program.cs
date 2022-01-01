using System;

namespace _1007_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int A,B,C,D,Diferenca;

            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            C = Convert.ToInt32(Console.ReadLine());
            D = Convert.ToInt32(Console.ReadLine());

            Diferenca = (A * B) - (C * D);

            Console.WriteLine("DIFERENCA = " + Diferenca.ToString());

        }
    }
}

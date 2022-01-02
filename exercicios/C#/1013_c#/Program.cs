using System;

namespace _1013_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            String line = Console.ReadLine();

            String[] Valores = line.Split(' ');
            int A = Convert.ToInt32(Valores[0]);
            int B = Convert.ToInt32(Valores[1]);
            int C = Convert.ToInt32(Valores[2]);

            double MaiorAB = (A+B + Math.Abs(A-B))/2;

            double MaiorABC = (MaiorAB + C + Math.Abs(MaiorAB - C)) / 2;

            Console.WriteLine("{0} eh o maior",MaiorABC);
        }
    }
}

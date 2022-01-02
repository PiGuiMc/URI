using System;

namespace _1017_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tempo = Convert.ToInt32(Console.ReadLine());
            int Velocidade = Convert.ToInt32(Console.ReadLine());

            double Result = (Convert.ToDouble(Tempo) * Convert.ToDouble(Velocidade)) / 12;

            Console.WriteLine("{0}",Result.ToString("0.000"));
        }
    }
}

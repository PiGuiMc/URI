using System;

namespace _1014_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int Km = Convert.ToInt32(Console.ReadLine());
            double Litros = Convert.ToDouble(Console.ReadLine());

            double Consumo = Km / Litros;

            Console.WriteLine("{0} km/l",Consumo.ToString("0.000"));
        }
    }
}

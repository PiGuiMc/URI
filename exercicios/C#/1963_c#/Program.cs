using System;

namespace _1963_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valor = Console.ReadLine().Split(' ');

            double precoA = Convert.ToDouble(valor[0]) , precoN = Convert.ToDouble(valor[1]),total=0;

            total = ((precoN * 100)/precoA) - 100;

            Console.WriteLine("{0}%",total.ToString("0.00"));
        }
    }
}

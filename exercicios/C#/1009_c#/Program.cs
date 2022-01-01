using System;

namespace _1009_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            double SalFixo, ValorVendas, Total;

            Nome = Convert.ToString(Console.ReadLine());
            SalFixo = Convert.ToDouble(Console.ReadLine());
            ValorVendas = Convert.ToDouble(Console.ReadLine());

            if (ValorVendas > 0)
            {
                Total = (ValorVendas * 0.15) + SalFixo;
            }
            else
            {
                Total = SalFixo;
            }

            Console.WriteLine("TOTAL = R$ {0}", Total.ToString("0.00"));

        }
    }
}

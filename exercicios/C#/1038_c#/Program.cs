using System;

namespace _1038_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Valor = {' ', 4, 4.50, 5, 2, 1.5};

            String Line = Console.ReadLine();
            String[] Valores = Line.Split(' ');

            int Codigo = Convert.ToInt32(Valores[0]);
            int Qt = Convert.ToInt32(Valores[1]);
            

            double Total = Convert.ToDouble(Qt) * Valor[Codigo];
            Console.WriteLine("Total: R$ {0}",Total.ToString("0.00"));


        }
    }
}

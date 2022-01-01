using System;

namespace _1010_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            String line1 = Console.ReadLine();
            String line2 = Console.ReadLine();

            String[] values1 = line1.Split(' ');
            int CodPeca1 = Int32.Parse(values1[0]);
            int QtPeca1 = Int32.Parse(values1[1]);
            double ValorPeca1 = Convert.ToDouble(values1[2]);

            String[] values2 = line2.Split(' ');
            int CodPeca2 = Int32.Parse(values2[0]);
            int QtPeca2 = Int32.Parse(values2[1]);
            double ValorPeca2 = Convert.ToDouble(values2[2]);

            double Total1 = QtPeca1 * ValorPeca1;
            double Total2 = QtPeca2 * ValorPeca2;

            double Soma = Total1 + Total2;

            Console.WriteLine("VALOR A PAGAR: R$ {0}", Soma.ToString("0.00"));

        }
    }
}

using System;

namespace _1036_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            String Line = Console.ReadLine();

            String[] Valores = Line.Split(' ');

            double A = Convert.ToDouble(Valores[0]);
            double B = Convert.ToDouble(Valores[1]);
            double C = Convert.ToDouble(Valores[2]);

            double Delta = B*B - 4*A*C;

            double Raiz = Math.Sqrt(Delta);

            double Div = (2 * A);

            double R1 = (-B +  Raiz) / Div;

            double R2 = (-B - Raiz) / Div;

            if((Div == 0) || (Delta < 0))
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine("R1 = {0}",R1.ToString("0.00000"));
                Console.WriteLine("R2 = {0}",R2.ToString("0.00000"));
            }

            
        }
    }
}

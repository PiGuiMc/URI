using System;
namespace _1051_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            double i8 = 0, i18 = 0,i28 = 0, vimp = 0;
            double Valor = Convert.ToDouble(Console.ReadLine());

            if(Valor >= 0 && Valor <= 2000)
            {
                Console.WriteLine("Isento");
            }

            else if(Valor >= 2000.01 && Valor <= 3000)
            {
                vimp = (Valor - 2000) * 0.08;
                Console.WriteLine("R$ {0}",vimp.ToString("0.00"));
            }
            else if(Valor >= 3000.01 && Valor <= 4500)
            {
                i8 = 0.08 * 1000;
                i18 = (Valor - 3000);
                vimp = (i18 * 0.18) + i8;
                Console.WriteLine("R$ {0}",vimp.ToString("0.00"));
            }
            else if(Valor >= 4500.01)
            {
                i8 = 0.08* 1000;
                i18 = 0.18 * 1500;
                i28 = Valor - 4500;
                vimp = i18 + i8 + (i28 * 0.28);
                Console.WriteLine("R$ {0}",vimp.ToString("0.00"));
            }
        }
    }
}

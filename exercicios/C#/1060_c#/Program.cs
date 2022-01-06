using System;

namespace _1060_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;

            for(int i = 0; i < 6; i++)
            {
                double Valor = Convert.ToDouble(Console.ReadLine());

                if(Valor > 0)
                {
                    cont += 1;
                }
            }
            Console.WriteLine("{0} valores positivos",cont.ToString());
        }
    }
}

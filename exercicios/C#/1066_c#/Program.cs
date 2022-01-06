using System;

namespace _1066_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int c_pares = 0, c_impar = 0, c_positivo =0, c_negativos = 0;

            for(int i = 0; i < 5; i++)
            {
                int v = Convert.ToInt32(Console.ReadLine());

                if(v % 2 == 0)
                {
                    c_pares +=1;
                }
                if(v % 2 != 0)
                {
                    c_impar += 1;
                }

                if(v > 0)
                {
                    c_positivo += 1;
                }
                if(v < 0)
                {
                    c_negativos += 1;
                }
            }
            Console.WriteLine("{0} valor(es) par(es)\n{1} valor(es) impar(es)\n{2} valor(es) positivo(s)\n{3} valor(es) negativo(s)",c_pares.ToString(),c_impar.ToString(),c_positivo.ToString(),c_negativos.ToString());
        }
    }
}

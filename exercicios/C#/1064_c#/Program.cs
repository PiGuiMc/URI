using System;

namespace _1064_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double soma = 0;
            for(int i =0; i< 6;i++)
            {
                double valor = Convert.ToDouble(Console.ReadLine());

                if(valor > 0)
                {
                    count += 1;
                    soma += valor;
                }

            }
            Console.WriteLine("{0} valores positivos",count.ToString());
            Console.WriteLine((soma / count).ToString("0.0"));
        }
    }
}

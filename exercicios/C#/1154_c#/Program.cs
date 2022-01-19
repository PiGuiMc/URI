using System;

namespace _1154_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()), soma = 0;
            double media, i =0;

            while(n>=0){
                soma += n;
                i += 1;

                n = Convert.ToInt32(Console.ReadLine());
            }
            media = soma / i;

            Console.WriteLine("{0}",media.ToString("0.00"));
        }
    }
}

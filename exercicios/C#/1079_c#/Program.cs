using System;

namespace _1079_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while(i < n){
                String entrada = Console.ReadLine();
                String[] valor = entrada.Split(' ');
                double n1 = Convert.ToDouble(valor[0]);
                double n2 = Convert.ToDouble(valor[1]);
                double n3 = Convert.ToDouble(valor[2]);

                double media = (n1*2+n2*3+n3*5)/10;
                
                Console.WriteLine(media.ToString("0.0"));

                i+=1;
            }
        }
    }
}

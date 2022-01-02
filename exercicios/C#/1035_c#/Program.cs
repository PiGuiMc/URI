using System;

namespace _1035_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            String Line = Console.ReadLine();

            String[] Valores = Line.Split(' ');
            
            int A = Convert.ToInt32(Valores[0]);
            int B = Convert.ToInt32(Valores[1]);
            int C = Convert.ToInt32(Valores[2]);
            int D = Convert.ToInt32(Valores[3]);

            if(B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

        }
    }
}

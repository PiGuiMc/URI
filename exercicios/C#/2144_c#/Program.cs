using System;

namespace _2144_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double sumM = 0.0, i = 1, total = 0.0;

            while(true)
            {
                String[] entrada = Console.ReadLine().Split(' ');

                int w1 = Convert.ToInt32(entrada[0]);
                int w2 = Convert.ToInt32(entrada[1]);
                double r = Convert.ToInt32(entrada[2]);
                double r1 = r/30;
                double m2 = (w2 * (1 + r1));
                double m1 = (w1 * (1 + r1));
                double m = (m2 + m1) / 2;

                sumM = m + sumM;

                if (w1 == 0 && w2 == 0 && r == 0)
                {
                    break;
                }

                else if(m >= 1 && m < 13)
                {
                        Console.WriteLine("Nao vai da nao");
                }
                else if(m >= 13 && m < 14)
                {
                    Console.WriteLine("E 13");
                }
        
                else if( m >= 14 && m < 40)
                {
                    Console.WriteLine("Bora, hora do show! BIIR!");
                }
                else if( m >= 40 && m <= 60)
                {
                    Console.WriteLine("Ta saindo da jaula o monstro!");
                }
        
                else if( m > 60)
                {
                    Console.WriteLine("AQUI E BODYBUILDER!!");
                }
                i ++;
            }
            total = sumM / (i - 1);
            if (total > 40.00)
            {
                Console.WriteLine();
                Console.WriteLine("Aqui nois constroi fibra rapaz! Nao e agua com musculo!");
            }

        }
    }
}

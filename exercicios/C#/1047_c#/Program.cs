using System;
using System.Globalization;
namespace _1047_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Falta corrigir!
            int hr = 0, min= 0,min1 = 0;
            String[] Entrada = Console.ReadLine().Split(' ');

            int h1 = Convert.ToInt32(Entrada[0], CultureInfo.InvariantCulture);
            int m1 = Convert.ToInt32(Entrada[1], CultureInfo.InvariantCulture);
            int h2 = Convert.ToInt32(Entrada[2], CultureInfo.InvariantCulture);
            int m2 = Convert.ToInt32(Entrada[3], CultureInfo.InvariantCulture);

            if(h1 == h2 && m1 == m2)
            {
                hr = 24;
                min = 0;
            }
            else if(h1 < h2 && m1 < m2)
            {   
                min1 = (h2 - h1) * 60 + (m2 - m1);
                hr = min1 / 60;
                min = min1 - (hr * 60);
            }

            else if(h1 < h2 && m1 > m2)
            {   
                min1 = (h2 - h1) * 60 + (m1 - m2);
                hr = min1 / 60;
                min = min1 - (hr * 60);
            }

            else if (h1 > h2 && m1 > m2)
            {
                min1 = (h1 - h2) * 60 + (m2 - m1);
                hr = 24 - min1 / 60;
                min = min1 - (hr * 60);
            }
            else if(h1 == h2 & m1 < m2)
            {
                hr = h1;
                min = m2 - m1;
            }
            else if(h1 == h2 & m1 > m2)
            {
                hr = m1;
                min = m1 - m2;
            }

            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)",hr.ToString(),min.ToString());
        }
    }
}

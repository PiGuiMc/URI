using System;

namespace _1041_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            String Entrada = Console.ReadLine();

            String [] Valores = Entrada.Split(' ');

            double X = Convert.ToDouble(Valores[0]);
            double Y = Convert.ToDouble(Valores[1]);

            if ((X == 0) && (Y == 0))
            {
                Console.WriteLine("Origem");
            }

            else if( X > 0.0 && Y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if(X < 0.0 && Y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if(X < 0.0 && Y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if(X > 0.0 && Y < 0.0)
            {
                Console.WriteLine("Q4");
            }
            else if(X > 0 || X < 0 && Y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if(Y > 0 || Y < 0 && X ==0)
            {
                Console.WriteLine("Eixo Y");
            }
        }
    }
}

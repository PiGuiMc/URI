using System;

namespace _2175_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] entrada = Console.ReadLine().Split(' ');

            double o = Convert.ToDouble(entrada[0]);
            double b = Convert.ToDouble(entrada[1]);
            double i = Convert.ToDouble(entrada[2]);

            if(o == i || b == o || i == b)
            {
                Console.WriteLine("Empate");
            }

            else if(o < b && o < i)
            {
                Console.WriteLine("Otavio");
            }

            else if(b < o && b < i)
            {
                Console.WriteLine("Bruno");
            }

            else if(i < b && i < o)
            {
                Console.WriteLine("Ian");
            }

        
        }
    }
}

using System;
using System.Globalization;
namespace _1046_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String[] Entrada = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(Entrada[0],CultureInfo.InvariantCulture); 
            int b = Convert.ToInt32(Entrada[1],CultureInfo.InvariantCulture);

            if(a == b)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            else if(a < b)
            {
                int tempo = b - a;
                Console.WriteLine("O JOGO DUROU {0} HORA(S)",tempo.ToString());
            }

            else if(a > b)
            {
                int tempo = 24 - (a - b);
                Console.WriteLine("O JOGO DUROU {0} HORA(S)",tempo.ToString());
            }
        }
    }
}

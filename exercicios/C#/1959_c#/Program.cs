using System;

namespace _1959_c_
{
    class Program
    {
        static void Main(string[] args)
        {  
            string[] valor = Console.ReadLine().Split(' ');

            long a = Convert.ToInt32(valor[0]);
            long b = Convert.ToInt32(valor[1]);

            Console.WriteLine(a*b);
        }
    }
}

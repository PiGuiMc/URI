using System;

namespace _1930_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valor = Console.ReadLine().Split(' ');

            int t1 = Convert.ToInt32(valor[0]) , t2 = Convert.ToInt32(valor[1]);
            int t3 = Convert.ToInt32(valor[2]), t4 = Convert.ToInt32(valor[3]);

            Console.WriteLine(t1-1 + t2-1 + t3-1 + t4);
        }
    }
}

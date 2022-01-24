using System;

namespace _1589_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine()),a,b;

            for(int i=0;i<x;i++){
                String line = Console.ReadLine();
                String[] valor = line.Split(' ');

                a = Convert.ToInt32(valor[0]);
                b = Convert.ToInt32(valor[1]);

                Console.WriteLine(a+b);
            }
        }
    }
}

using System;

namespace _1153_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()), fatorial = 1;

            while(n >= 1){
                fatorial = fatorial * n;
                n -=1;
            }
            Console.WriteLine(fatorial);
        }
    }
}

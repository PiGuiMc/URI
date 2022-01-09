using System;

namespace _1080_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, pos = 0, maior;
        
            maior = 0;
    
            for (i = 1; i < 101; i++){
                int v = Convert.ToInt32(Console.ReadLine());
        
                if (v > maior) {
                    maior = v;
                    pos = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine((pos).ToString());
        }
    }
}

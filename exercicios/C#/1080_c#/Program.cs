using System;

namespace _1080_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, pos = 0, maior;
            

            int []n = Convert.ToInt32(Console.ReadLine(n));
            maior = n;
    
            for (i = 1; i < 100; i++){
                Console.ReadLine(n);
        
                if (n[i] > maior) {
                    maior = n[i];
                    pos = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine((pos + 1).ToString());
        }
    }
}

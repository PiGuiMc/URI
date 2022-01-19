using System;

namespace _1173_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i =0;i<10;i++){
                
                Console.WriteLine("N[{0}] = {1}",i.ToString(),num.ToString());

                num *=2;
            }
        }
    }
}

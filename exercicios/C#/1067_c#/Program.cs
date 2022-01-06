using System;

namespace _1067_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i < x+1; i+=2)
            {
                    Console.WriteLine(i);        
            }
        }
    }
}

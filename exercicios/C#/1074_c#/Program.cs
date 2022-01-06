using System;

namespace _1074_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int v = Convert.ToInt32(Console.ReadLine());
                
                if(v > 0 && v % 2 == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if(v > 0 && v % 2 != 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }

                else if(v < 0 && v % 2 == 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if(v < 0 && v % 2 != 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }

                else if(v == 0)
                {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}

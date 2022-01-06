using System;

namespace _1070_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            for(int i = x; i < (x + 12); i++)
            {
                if(i %2 !=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

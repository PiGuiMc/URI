using System;

namespace _1073_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int elev = 0, i = 1;
            int n = Convert.ToInt32(Console.ReadLine());

            while(i <= n)
            {
                if(i % 2 == 0)
                {
                    elev = Convert.ToInt32(Math.Pow(i,2));
                    Console.WriteLine("{0}^2 = {1}",i.ToString(),elev.ToString());
                }
                i+=1;
            }
        }
    }
}

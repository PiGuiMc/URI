using System;

namespace _1143_c_
{
    class Program
    {
        static void Main(string[] args)
        {   
            int x = 1;
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<n+1;i++){
                Console.WriteLine("{0} {1} {2}",(x).ToString(),Math.Pow(x,2).ToString(),Math.Pow(x,3).ToString());
                x = x + 1;
            }
        }
    }
}

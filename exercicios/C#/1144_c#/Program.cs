using System;

namespace _1144_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            int n = Convert.ToInt32(Console.ReadLine());

            while(i<n){
                i += 1;
                Console.WriteLine("{0} {1} {2}",i.ToString(),Math.Pow(i,2).ToString(),Math.Pow(i,3));
                Console.WriteLine("{0} {1} {2}",i.ToString(),(Math.Pow(i,2)+1).ToString(),(Math.Pow(i,3)+1));
            }
        }
    }
}

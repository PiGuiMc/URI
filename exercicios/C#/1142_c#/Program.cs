using System;

namespace _1142_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i<n+1;i++){
                Console.WriteLine("{0} {1} {2} PUM",x.ToString(),(x+1).ToString(),(x+2).ToString());
                x = x + 4;
            }
        }
    }
}

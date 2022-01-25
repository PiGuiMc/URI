using System;

namespace _1866_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<n; i++){
                int v = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}",(v%2).ToString());
            }
        }
    }
}

using System;

namespace _1078_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++){
                Console.WriteLine("{0} x {1} = {2}",i,v,i*v);
            }
        }
    }
}

using System;

namespace _1962_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<n; i++){
                int t = Convert.ToInt32(Console.ReadLine()), anos=0;

                if(t>2015){
                    anos = (t - 2015) + 1;
                    Console.WriteLine("{0} A.C.",anos.ToString());
                }else if(t<2015){
                    anos = (2015 - t);
                    Console.WriteLine("{0} D.C.",anos.ToString());
                }else if(t == 2015){
                    Console.WriteLine("1 A.C.");
                }
            }
        }
    }
}

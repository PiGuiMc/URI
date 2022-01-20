using System;

namespace _1176_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<t;i++){
                int x = Convert.ToInt32(Console.ReadLine());
                long[] f = new long[x+t];
                f[0] = 0;
                f[1] = 1;
                
                if(x>1){
                    for(int j=2;j<=x+1;j++){ 
                        f[j] = f[j-2]+f[j-1];
                    }
                    Console.WriteLine("Fib({0}) = {1}",x.ToString(),f[x].ToString());
                }else if(x<=1){
                    Console.WriteLine("Fib({0}) = {1}",x.ToString(),x.ToString());
                }

            }
        }
    }
}
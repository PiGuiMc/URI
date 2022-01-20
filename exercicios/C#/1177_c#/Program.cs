using System;

namespace _1177_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine()),j=0,i=0;

            while(i<1000){
                Console.WriteLine("N[{0}] = {1}",i,j);

                i+=1;
                j+=1;

                if(j==num){
                    j = 0;
                }
            }
        }
    }
}

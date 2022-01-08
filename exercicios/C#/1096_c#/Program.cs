using System;

namespace _1096_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=9;i+=2){
                for(int j=7;j>=5;j--){
                    Console.WriteLine("I={0} J={1}",i,j);
                }
            }
        }
    }
}

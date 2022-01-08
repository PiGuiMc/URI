using System;

namespace _1097_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=7, b =6, c=5, i=1;

            while(i <=9){
                Console.WriteLine("I={0} J={1}",i,a);
                Console.WriteLine("I={0} J={1}",i,b);
                Console.WriteLine("I={0} J={1}",i,c);

                a+=2;
                b+=2;
                c+=2;
                i+=2;
            }
        }
    }
}

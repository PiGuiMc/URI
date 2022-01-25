using System;

namespace _1933_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valor = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(valor[0]) , b = Convert.ToInt32(valor[1]);

            if(a == b){
                Console.WriteLine(a);
            }else if(a > b){
                Console.WriteLine(a);
            }else if( a< b){
                Console.WriteLine(b);
            }
        }
    }
}

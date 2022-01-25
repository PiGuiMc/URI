using System;

namespace _1929_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valor = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(valor[0]) , b = Convert.ToInt32(valor[1]);
            int c = Convert.ToInt32(valor[2]) , d = Convert.ToInt32(valor[3]);

            if(a > 0 && a<= 100 && b > 0 && b <= 100 && c > 0 && c <= 100 && d > 0 && d<=100){
                
                if(((a+b)>c) && ((b+c) > a) && ((a+c)>b)){
                    Console.WriteLine("S");
                }else if(((b + c) > d) && ((c + d) > b) && ((b + d) > c)){
                    Console.WriteLine("S");
                }else if(((a + c) > d) && ((c + d) >a) && ((a + d > c))){
                    Console.WriteLine("S");
                }else if(((a + b)> d) && ((b + d) > a) && ((a + d > b))){
                    Console.WriteLine("S");
                }else{
                Console.WriteLine("N");
            }
            }
        }
    }
}

using System;

namespace _1133_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior, menor;

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if(x>y){maior=x;menor=y;}else{maior=y;menor=x;}

            for(int i = menor+1;i<maior;i++){
                if(i%5==2 || i%5==3){
                    Console.WriteLine(i);
                }
            }
        }
    }
}

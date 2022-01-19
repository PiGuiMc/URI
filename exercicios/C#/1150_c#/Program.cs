using System;

namespace _1150_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=2, s = 1, soma,z;

            int x = Convert.ToInt32(Console.ReadLine());

            z = x - 1;

            soma = x;

            while(z <= x){
                z = Convert.ToInt32(Console.ReadLine());
            }
            while(soma <= z){
                soma = soma  + x + s;

                if(soma <= z){
                    i +=1;
                    s += 1;
                }
            }
            Console.WriteLine(i);
        }
    }
}

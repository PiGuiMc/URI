using System;

namespace _1113_c_
{
    class Program
    {
        static void Main(string[] args)
        {
           while(true){
            string line = Console.ReadLine();
            string[] valor = line.Split(" ");

            int x = Convert.ToInt32(valor[0]);
            int y = Convert.ToInt32(valor[1]);

            if(x == y){
                break;
            }else if(x > y){
                Console.WriteLine("Decrescente");
            }else{
                Console.WriteLine("Crescente");
            }
           }
        }
    }
}

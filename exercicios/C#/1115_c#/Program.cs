using System;

namespace _1115_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                string[] line = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(line[0]);
                int y = Convert.ToInt32(line[1]);

                if(x == 0 || y == 0){
                    break;
                }
                if(x > 0 && y > 0){
                    Console.WriteLine("primeiro");
                }else if(x < 0 && y > 0){
                    Console.WriteLine("segundo");
                }else if(x < 0 && y < 0){
                    Console.WriteLine("terceiro");
                }else if(x > 0 && y < 0){
                    Console.WriteLine("quarto");
                }
            }
        }
    }
}

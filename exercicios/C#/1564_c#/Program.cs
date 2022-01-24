using System;

namespace _1564_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true) {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    break;
                
                int n = Convert.ToInt32(input);

                if(n == 0){
                    Console.WriteLine("vai ter copa!");
                }else if(n > 0){
                    Console.WriteLine("vai ter duas!");
                }
            }
        }
    }
}

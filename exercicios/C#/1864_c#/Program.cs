using System;

namespace _1864_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase1 = "LIFE IS NOT A PROBLEM TO BE SOLVED";

            int n = Convert.ToInt32(Console.ReadLine());
            
            if (n <= 34){
            Console.WriteLine(frase1.Substring(0,n));
            }
        }
    }
}

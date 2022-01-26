using System;

namespace _1984_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine(), teste="";

            for(int i = str.Length; i >0; i--){
                teste += str.Substring(i-1,1);
            }
            Console.WriteLine(teste);
        }
    }
}

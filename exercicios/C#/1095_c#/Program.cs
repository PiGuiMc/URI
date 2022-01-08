using System;

namespace _1095_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = -2;
            for(int j = 60; j >= 0; j = j - 5){
                Console.WriteLine("I={0} J={1}", (i+3).ToString(),j.ToString());
                i += 3;
            }
        }
    }
}

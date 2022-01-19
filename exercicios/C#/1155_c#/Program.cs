using System;

namespace _1155_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;

            for(int i=1; i < 101;i++){
                s = Convert.ToDouble(s + Convert.ToDouble(1)/Convert.ToDouble(i));
            }
            Console.WriteLine(s.ToString("0.00"));
        }
    }
}

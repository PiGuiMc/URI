using System;

namespace _1156_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0, j = 1;

            for(int i = 1;i<40;i+=2){
                s = s + Convert.ToDouble(i) / j;
                j *= 2;
            }
            Console.WriteLine(s.ToString("0.00"));
        }
    }
}

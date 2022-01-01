using System;

namespace _1005_c
{
    class Program
    {
        static void Main(string[] args)
        {
            double A,B,Media;

            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            
            Media = ((A*3.5) + (B*7.5)) / 11;

            Console.WriteLine("MEDIA = "+ Media.ToString("0.00000"));

        }
    }
}

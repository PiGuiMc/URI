using System;

namespace _1006_C
{
    class Program
    {
        static void Main(string[] args)
        {
            double A,B,C,Media;

            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            C = Convert.ToDouble(Console.ReadLine());

            Media = ((A*2) + (B*3) + (C*5)) / 10;

            Console.WriteLine("MEDIA = " + Media.ToString("0.0"));
        }
    }
}

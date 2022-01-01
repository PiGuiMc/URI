using System;

namespace _1011_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = Convert.ToDouble(Console.ReadLine());

            double Volume = (4/3.0) * 3.14159 * (R*R*R);

            Console.WriteLine("VOLUME = {0}", Volume.ToString("0.000"));
        }
    }
}

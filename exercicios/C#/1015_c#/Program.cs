using System;

namespace _1015_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            String Line1 = Console.ReadLine();
            String Line2 = Console.ReadLine();

            String[] Valores1 = Line1.Split(' ');
            double X1 = Convert.ToDouble(Valores1[0]);
            double Y1 = Convert.ToDouble(Valores1[1]);

            String[] Valores2 = Line2.Split(' ');
            double X2 = Convert.ToDouble(Valores2[0]);
            double Y2 = Convert.ToDouble(Valores2[1]);

            double PX = Math.Pow(X2 - X1,2);

            double PY = Math.Pow(Y2 - Y1,2);

            double Result = Math.Sqrt(PX + PY);

            Console.WriteLine(Result.ToString("0.0000"));

        }
    }
}

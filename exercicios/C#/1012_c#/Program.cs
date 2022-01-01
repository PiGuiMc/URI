using System;

namespace _1012_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            String line = Console.ReadLine();

            String[] Values = line.Split(' ');
            double A = Convert.ToDouble(Values[0]);
            double B = Convert.ToDouble(Values[1]);
            double C = Convert.ToDouble(Values[2]);

            double Triangulo = (A * C) / 2;

            double Circulo = 3.14159 * (C * C);

            double Trapezio = ((A + B) / 2) * C;

            double Quadrado = B * B;

            double Retangulo = A * B;

            Console.WriteLine("TRIANGULO: {0}",Triangulo.ToString("0.000"));
            Console.WriteLine("CIRCULO: {0}",Circulo.ToString("0.000"));
            Console.WriteLine("TRAPEZIO: {0}",Trapezio.ToString("0.000"));
            Console.WriteLine("QUADRADO: {0}",Quadrado.ToString("0.000"));
            Console.WriteLine("RETANGULO: {0}",Retangulo.ToString("0.000"));
        }
    }
}

using System;
using System.Globalization;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

        if(a >= (b+c) || b >= (a+c) || c >= (a+b)){
            Console.WriteLine("NAO FORMA TRIANGULO");
        }else if(a*a == (b*b + c*c) || b*b == (a*a + c*c) || c*c == (a*a + b*b)){
            Console.WriteLine("TRIANGULO RETANGULO");
        }else if(a*a > (b*b + c*c) || b*b > (a*a + c*c) || c*c > (a*a + b*b)){
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        }else if(a*a < (b*b + c*c) || b*b < (a*a + c*c) || c*c < (a*a + b*b)){
            Console.WriteLine("TRIANGULO ACUTANGULO");}
        if(a == b && a == c){
            Console.WriteLine("TRIANGULO EQUILATERO");
        }
        if((a == b && a != c)  || (a == c && a != b) || (b == c && b != a)){
            Console.WriteLine("TRIANGULO ISOSCELES");}
        }
    }
}

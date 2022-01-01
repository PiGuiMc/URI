using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int a = Convert.ToInt32(Console.ReadLine());
      int b = Convert.ToInt32(Console.ReadLine());

      int soma;
      soma  = a + b;
      Console.WriteLine("X = " + soma);
    }
  }
}
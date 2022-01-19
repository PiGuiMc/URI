using System;

namespace _1151_c_
{
    class Program
    {
        static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine()), anterior1 = 0, anterior2 = 1; ;

        for (int i = 0; i < n; i++)
        {
            if (i == n - 1)
            {
                Console.WriteLine(anterior1);
            }
            else
            {
                Console.Write(anterior1 + " ");
            }
            int novo = anterior1 + anterior2;
            anterior1 = anterior2;
            anterior2 = novo;
        }
        }
    }
}

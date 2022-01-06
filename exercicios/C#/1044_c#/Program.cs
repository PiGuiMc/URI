using System;

namespace _1044_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Entrada = Console.ReadLine().Split();
            int A = Convert.ToInt32(Entrada[0]);
            int B = Convert.ToInt32(Entrada[1]);
            int op1 = B%A;
            int op2 = A%B;
            if((op1 == 0) || (op2 == 0))
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}

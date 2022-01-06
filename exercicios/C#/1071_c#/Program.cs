using System;

namespace _1071_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0, menor = 0,soma = 0;
            int n1 = Convert.ToInt32(Console.ReadLine()), n2 = Convert.ToInt32(Console.ReadLine());

            if(n1 > n2)
            {
                maior = n1;
                menor = n2;
            }
            else
            {
                maior = n2;
                menor = n1;
            }

            menor += 1;

            while(menor < maior)
            {
                if(menor % 2 != 0)
                {
                    soma += menor;
                }
                menor +=1;
            }
            Console.WriteLine(soma.ToString());

        }
    }
}

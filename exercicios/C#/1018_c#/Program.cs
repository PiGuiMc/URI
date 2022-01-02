using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Notas = {100, 50, 20, 10, 5, 2, 1};

            int Qt_Cedulas = 0;

            int Valor = Convert.ToInt32(Console.ReadLine());

            var Total = Valor;

            Console.WriteLine(Valor);
            foreach (int Nota in Notas)
            {
                Qt_Cedulas = (int)(Total / Nota);

                Console.WriteLine("{0} nota(s) de R$ {1},00",Qt_Cedulas.ToString(),Nota.ToString());
                Total = Total - (Qt_Cedulas * Nota);
            }

        }
    }
}

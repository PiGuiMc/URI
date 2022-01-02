using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Notas = {100, 50, 20, 10, 5, 2};

            float[] Moedas = {1.00f , 0.50f, 0.25f, 0.10f, 0.05f, 0.01f};

            int Qt_Cedulas = 0, Qt_Moedas = 0;

            double Valor = Double.Parse(Console.ReadLine());

            var Total = Valor;

            Console.WriteLine("NOTAS:");
            foreach (int Nota in Notas)
            {
                Qt_Cedulas = (int)(Total / Nota);

                Console.WriteLine("{0} nota(s) de R$ {1}.00",Qt_Cedulas.ToString(),Nota.ToString());
                Total = Total - (Qt_Cedulas * Nota);
            }

            Console.WriteLine("MOEDAS:");   

            foreach(double Moeda in Moedas)
            {
                
                //Console.WriteLine("Total moeda: " + Total);
                Qt_Moedas = (int)(Total / Moeda);

                Console.WriteLine("{0} moeda(s) de R$ {1}",Qt_Moedas.ToString(),Moeda.ToString("0.00"));
                Total -= Math.Round((Qt_Moedas * Moeda),2);
            }

        }
    }
}

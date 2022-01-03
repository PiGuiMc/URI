using System;

namespace _1040_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            double Media = 0, NExame = 0;

            String Line = Console.ReadLine();

            String[] Valores = Line.Split(' ');

            double N1 = Convert.ToDouble(Valores[0]);
            double N2 = Convert.ToDouble(Valores[1]);
            double N3 = Convert.ToDouble(Valores[2]);
            double N4 = Convert.ToDouble(Valores[3]);

            Media = ((N1 * 2) + (N2 * 3) + (N3 * 4) + (N4 * 1)) /10;

            if(Media >= 7)
            {   
                Console.WriteLine("Media: {0}",Media.ToString());
                Console.WriteLine("Aluno aprovado.");
            }

            else if (Media >= 5 && Media <= 6.9)
            {
                Console.WriteLine("Media: {0}",Media.ToString("0.0"));
                Console.WriteLine("Aluno em exame.");

                NExame = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nota do exame: {0}",NExame.ToString("0.0"));

                if(((Media + NExame)/2) >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: {0}",((Media + NExame)/2).ToString("0.0"));                    
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
            }
            else if (Media < 5)
            {   
                Console.WriteLine("Media: "+ Math.Round(Media,1).ToString());
                Console.WriteLine("Aluno reprovado.");
            }

        }
    }
}

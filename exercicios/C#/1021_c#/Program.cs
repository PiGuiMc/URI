//Precisa arrumar 0,01 está errado!

using System;

namespace _1021_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            double Qt100 = 0, Qt50 = 0, Qt20 = 0, Qt10 = 0, Qt5 = 0, Qt2 = 0, Sobra = 0;
            double Md1 = 0, Md050 = 0, Md025 = 0, Md010 = 0, Md005 = 0, Md001 = 0;

            double Valor = Convert.ToDouble(Console.ReadLine());

            if(Valor >= 100)
            {
                Qt100 = (Valor/100) - (Valor / 100) % 1;
                Sobra = ((Valor / 100) % 1) * 100;
            }

            if(Valor >= 50 && Valor < 100 || Sobra >= 50 && Sobra < 100)
            {
                if(Sobra >= 50 && Sobra < 100)
                {
                    Qt50 = (Sobra / 50) - (Sobra / 50) % 1;
                    Sobra = ((Sobra / 50) % 1) * 50;
                }
                else
                {
                    Qt50 = (Valor / 50) - (Valor / 50) % 1;
                    Sobra = ((Valor / 50) % 1) * 50;
                }
            }
            
            if(Valor >= 20 && Valor < 50 || Sobra >= 20 && Sobra < 50)
            {
                if(Sobra >= 20 && Sobra < 50)
                {
                    Qt20 = (Sobra / 20) - (Sobra / 20) % 1;
                    Sobra = ((Sobra / 20) % 1) * 20;
                }
                else
                {
                    Qt20 = (Valor / 20) - (Valor / 20) % 1;
                    Sobra = ((Valor / 20) % 1) * 20;
                }
            }
            
            if(Valor >= 10 && Valor < 20 || Sobra >= 10 && Sobra < 20)
            {
                if(Sobra >= 10 && Sobra < 20)
                {
                    Qt10 = (Sobra / 10) - (Sobra / 10) % 1;
                    Sobra = ((Sobra / 10) % 1) * 10;
                }
                else
                {
                    Qt10 = (Valor / 10) - (Valor / 10) % 1;
                    Sobra = ((Valor / 10) % 1) * 10;
                }
            }

            if(Valor >= 5 && Valor < 10 || Sobra >= 5 && Sobra < 10)
            {
                if(Sobra >= 5 && Sobra < 10)
                {
                    Qt5 = (Sobra / 5) - (Sobra / 5) % 1;
                    Sobra = ((Sobra / 5) % 1) * 5;
                }
                else
                {
                    Qt5 = (Valor / 5) - (Valor / 5) % 1;
                    Sobra = ((Valor / 5) % 1) * 5;
                }
            }
            
            if(Valor >= 2 && Valor < 5 || Sobra >= 2 && Sobra < 5)
            {
                if(Sobra >= 2 && Sobra < 5)
                {
                    Qt2 = (Sobra / 2) - (Sobra / 2) % 1;
                    Sobra = ((Sobra / 2) % 1) * 2;
                }
                else
                {
                    Qt2 = (Valor / 2) - (Valor / 2) % 1;
                    Sobra = ((Valor / 2) % 1) * 2;
                }
            }

            if(Valor >= 1 && Valor < 2 || Sobra >= 1 && Sobra < 2)
            {
                if(Sobra >= 1 && Sobra < 2)
                {
                    Md1 = (Sobra / 1) - (Sobra / 1) % 1;
                    Sobra = ((Sobra / 1) % 1) * 1;
                }
                else
                {
                    Md1 = (Valor / 1) - (Valor / 1) % 1;
                    Sobra = ((Valor / 1) % 1) * 1;
                }
            }
            
            if(Valor >= 0.5 && Valor < 1 || Sobra >= 0.5 && Sobra < 1)
            {
                if(Sobra >= 0.5 && Sobra < 1)
                {
                    Md050 = (Sobra / 0.5) - (Sobra / 0.5) % 1;
                    Sobra = ((Sobra / 0.5) % 1) * 0.5;
                }
                else
                {
                    Md050 = (Valor / 0.5) - (Valor / 0.5) % 1;
                    Sobra = ((Valor / 0.5) % 1) * 0.5;
                }
            }

            if(Valor >= 0.25 && Valor < 0.5 || Sobra >= 0.25 && Sobra < 0.5)
            {
                if(Sobra >= 0.25 && Sobra < 0.5)
                {
                    Md025 = (Sobra / 0.25) - (Sobra / 0.25) % 1;
                    Sobra = ((Sobra / 0.25) % 1) * 0.25;
                }
                else
                {
                    Md025 = (Valor / 0.25) - (Valor / 0.25) % 1;
                    Sobra = ((Valor / 0.25) % 1) * 0.25;
                }
            }

            if(Valor >= 0.10 && Valor < 0.25 || Sobra >= 0.10 && Sobra < 0.25)
            {
                if(Sobra >= 0.10 && Sobra < 0.25)
                {
                    Md010 = (Sobra / 0.10) - (Sobra / 0.10) % 1;
                    Sobra = ((Sobra / 0.1) % 1) * 0.1;
                }
                else
                {
                    Md010 = (Valor / 0.1) - (Valor / 0.1) % 1;
                    Sobra = ((Valor / 0.1) % 1) * 0.1;
                }
            }

            if(Valor >= 0.05 && Valor < 0.1 || Sobra >= 0.05 && Sobra < 0.1)
            {
                if(Sobra >= 0.05 && Sobra < 0.1)
                {
                    Md005 = (Sobra / 0.05) - (Sobra / 0.05) % 1;
                    Sobra = ((Sobra / 0.05) % 1) * 0.05;
                }
                else
                {
                    Md005 = (Valor / 0.05) - (Valor / 0.05) % 1;
                    Sobra = ((Valor / 0.05) % 1) * 0.05;
                }
            }
            if(Sobra >= 0.01 && Sobra < 0.05)
            {
                Md001 = Convert.ToInt32((Sobra,2)) / 0.01;
            }
            if(Valor >= 0.01 && Valor < 0.05)
            {
                Md001 = Convert.ToInt32((Valor,2)) / 0.01;
            }
            
            Console.WriteLine("NOTAS:");
            Console.WriteLine("{0} nota(s) de R$ 100.00", Qt100.ToString());
            Console.WriteLine("{0} nota(s) de R$ 50.00",Qt50.ToString());
            Console.WriteLine("{0} nota(s) de R$ 20.00",Qt20.ToString());
            Console.WriteLine("{0} nota(s) de R$ 10.00",Qt10.ToString());
            Console.WriteLine("{0} nota(s) de R$ 5.00",Qt5.ToString());
            Console.WriteLine("{0} nota(s) de R$ 2.00",Qt2.ToString());
            Console.WriteLine("MOEDAS:");
            Console.WriteLine("{0} moeda(s) de R$ 1.00",Md1.ToString());
            Console.WriteLine("{0} moeda(s) de R$ 0.50",Md050.ToString());
            Console.WriteLine("{0} moeda(s) de R$ 0.25",Md025.ToString());
            Console.WriteLine("{0} moeda(s) de R$ 0.10",Md010.ToString());
            Console.WriteLine("{0} moeda(s) de R$ 0.05",Md005.ToString());
            Console.WriteLine("{0} moeda(s) de R$ 0.01",Md001.ToString());

        }
    }
}

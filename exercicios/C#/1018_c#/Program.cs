using System;

namespace _1018_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sobra = 0,Qt100 = 0,Qt50 = 0, Qt20 = 0, Qt10 = 0, Qt5 = 0, Qt2 = 0, Qt1 = 0;
        
            int Valor = Convert.ToInt32(Console.ReadLine());

            if(Valor >= 100)
            {
                Qt100 = (Valor / 100);
                Sobra = Valor - (Qt100*100);
            }

            if( Valor >= 50 && Valor < 100 || Sobra >= 50 && Sobra < 100)
            {
                if(Sobra >= 50 && Sobra < 100)
                {
                    Qt50 = Sobra / 50;
                    Sobra = Sobra - (Qt50 * 50);
                }
                else
                {
                    Qt50 = Valor / 50;
                    Sobra = Valor - (Qt50 * 50);
                }
            }

            if(Valor >= 20 && Valor < 50 || Sobra >= 20 && Sobra < 50)
            {
                if(Sobra >= 20 && Sobra < 50)
                {
                    Qt20 = Sobra / 20;
                    Sobra = Sobra - (Qt20 * 20);
                }
                else
                {
                    Qt20 = Valor / 20;
                    Sobra = Valor - (Qt20 * 20);

                }
            }

            if(Valor >= 10 && Valor < 20 || Sobra >= 10 && Sobra < 20)
            {
                if(Sobra >= 10 && Sobra < 20)
                {
                 Qt10 = Sobra / 10;
                 Sobra = Sobra - (Qt10 * 10);   
                }
                else
                {
                    Qt10 = Valor / 10;
                    Sobra = Valor - (Qt10 * 10);
                }
            }

            if(Valor >= 5 && Valor < 10 || Sobra >= 5 && Sobra < 10)
            {
                if(Sobra >=5 && Sobra < 10)
                {
                    Qt5 = Sobra / 5;
                    Sobra = Sobra - (Qt5 * 5);
                }
                else
                {
                    Qt5 = Valor / 5;
                    Sobra = Valor - (Qt5 * 5);
                }
            }

            if(Valor >= 2 && Valor < 5 || Sobra >= 2 && Sobra < 5)
            {
                if(Sobra >=2 && Sobra < 5)
                {
                    Qt2 = Sobra / 2;
                    Sobra = Sobra - (Qt2 * 2);
                }
                else
                {
                    Qt2 = Valor / 2;
                    Sobra = Valor - (Qt2 * 2);
                }
            }
            
            if(Valor >= 1 && Valor < 2 || Sobra >= 1 && Sobra < 2)
            {
                if(Sobra >= 1 && Sobra < 2)
                {
                 Qt1 = Sobra / 1;   
                }
                else
                {
                    Qt1 = Valor / 1;
                }
            }
            Console.WriteLine(Valor.ToString());
            Console.WriteLine("{0} nota(s) de R$ 100,00",Qt100.ToString());
            Console.WriteLine("{0} nota(s) de R$ 50,00", Qt50.ToString());
            Console.WriteLine("{0} nota(s) de R$ 20,00",Qt20.ToString());
            Console.WriteLine("{0} nota(s) de R$ 10,00",Qt10.ToString());
            Console.WriteLine("{0} nota(s) de R$ 5,00",Qt5.ToString());
            Console.WriteLine("{0} nota(s) de R$ 2,00",Qt2.ToString());
            Console.WriteLine("{0} nota(s) de R$ 1,00",Qt1.ToString());
        }
    }
}

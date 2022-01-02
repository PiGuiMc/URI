using System;

namespace _1020_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ano = 0, Mes = 0, Sobra = 0, Ndia = 0;

            int Dia = Convert.ToInt32(Console.ReadLine());

            if(Dia >= 365)
            {
                Ano = Dia / 365;
                Sobra = Dia - (Ano * 365);
            }

            if(Dia >= 30 && Dia < 365 || Sobra >= 30 && Sobra < 365)
            {
                if(Sobra >= 30 && Sobra < 365)
                {
                    Mes = Sobra / 30;
                    Sobra = Sobra - (Mes * 30);
                }
                else
                {
                    Mes = Dia / 30;
                    Sobra = Dia - (Mes * 30);
                }
            }

            if(Dia >= 0 && Dia < 30)
            {
                Ndia = Dia;
            }
            if(Sobra >= 0 && Sobra < 30)
            {
                Ndia = Sobra;
            }
            
            Console.WriteLine("{0} ano(s)",Ano.ToString());
            Console.WriteLine("{0} mes(es)",Mes.ToString());
            Console.WriteLine("{0} dia(s)",Ndia.ToString());
        }
    }
}

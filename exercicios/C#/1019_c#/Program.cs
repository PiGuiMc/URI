using System;

namespace _1019_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min = 0, Hora = 0, Sobra = 0, NSeg = 0;
            int Seg = Convert.ToInt32(Console.ReadLine());

            //Obter Hora 
            if(Seg >= 3600)
            {
                Hora = Seg / 3600;
                Sobra = Seg - (Hora * 3600);   
            }

            if(Seg >= 60 && Seg < 3600 || Sobra >= 60 && Sobra < 3600)
            {
                if(Sobra >= 60 && Sobra < 3600)
                {
                    Min = Sobra / 60;
                    Sobra = Sobra - (Min * 60);
                }
                else
                {
                    Min = Seg / 60;
                    Sobra = Seg - (Min * 60);
                }
            }

            if(Sobra >= 0 && Sobra < 60)
            {
                
                NSeg = Sobra;
            }
            if(Seg >= 0 && Seg < 60)
            {
                NSeg = Seg;
            }
            
            Console.WriteLine("{0}:{1}:{2}",Hora.ToString(),Min.ToString(),NSeg.ToString());
        }
    }
}

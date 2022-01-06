using System;

namespace _1061_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo_1, tempo_2,dias,horas,minutos, segundos;
            int minuto_seg, hora_seg, dia_seg,tempo;

            String[] Dia1 = Console.ReadLine().Split(' ');
            int Data1 = Convert.ToInt32(Dia1[1]);

            String[] tempo1 = Console.ReadLine().Split(' ');
            int Hora1 = Convert.ToInt32(tempo1[0]);
            int Min1 = Convert.ToInt32(tempo1[2]);
            int Seg1 = Convert.ToInt32(tempo1[4]);

            String[] Dia2 = Console.ReadLine().Split(' ');
            int Data2 = Convert.ToInt32(Dia2[1]);

            String[] tempo2 = Console.ReadLine().Split(' ');
            int Hora2 = Convert.ToInt32(tempo2[0]);
            int Min2 = Convert.ToInt32(tempo2[2]);
            int Seg2 = Convert.ToInt32(tempo2[4]);

            minuto_seg= 60;
            hora_seg = minuto_seg * 60;
            dia_seg = hora_seg * 24;

            tempo_1 = Seg1 + Min1*minuto_seg + Hora1*hora_seg + Data1*dia_seg;
            tempo_2 = Seg2 + Min2*minuto_seg + Hora2*hora_seg + Data2*dia_seg;
            
            if (tempo_1 < tempo_2)
            {
                tempo = tempo_2 - tempo_1;
                dias = Convert.ToInt32(tempo/dia_seg);

                tempo = tempo%dia_seg;
                horas = Convert.ToInt32(tempo/hora_seg);

                tempo = tempo%hora_seg;
                minutos = Convert.ToInt32(tempo/minuto_seg);
                
                tempo = tempo% minuto_seg;
                segundos = tempo;

                Console.WriteLine("{0} dia(s)\n{1} hora(s)\n{2} minuto(s)\n{3} segundo(s)",dias.ToString(), horas.ToString(), minutos.ToString(), segundos.ToString());
            }

        }
    }
}

﻿using System;
using System.Globalization;
namespace _1047_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 0, m= 0;
            String[] Entrada = Console.ReadLine().Split(' ');

            int hi = Convert.ToInt32(Entrada[0], CultureInfo.InvariantCulture);
            int mi = Convert.ToInt32(Entrada[1], CultureInfo.InvariantCulture);
            int hf = Convert.ToInt32(Entrada[2], CultureInfo.InvariantCulture);
            int mf = Convert.ToInt32(Entrada[3], CultureInfo.InvariantCulture);

        
    if(hi < hf){
        h = hf - hi;
        if(mi < mf){
            m = mf - mi;
        }else if(mi > mf){
            h = h - 1;
            m = (60 - mi) + mf;
        }else if(mi == mf){
            m = 0;
        }
    }
    if(hi > hf){
        h = (24 - hi) + hf;
        if(mi < mf){
            m = mf - mi;
        }else if(mi > mf){
            h = h - 1;
            m = (60 - mi) + mf;
        }else if(mi == mf){
            m = 0;
        }
    }
    if(hi == hf){
        if(mi < mf){
            m = mf - mi;
            h = 0;
        }else if(mi > mf){
            m = (60 - mi ) + mf;
            h = 23;
        }else if(mi == mf){
            h = 24;
            m = 0;
        }
    }
            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)",h.ToString(),m.ToString());
        }
    }
}

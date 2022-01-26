using System;

namespace _1985_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()),cod, qt;
            double vl = 0;

            for(int i=0; i<n; i++){
                string[] valor = Console.ReadLine().Split(' ');
                cod = Convert.ToInt32(valor[0]);
                qt = Convert.ToInt32(valor[1]);

                if(cod == 1001){
                    vl += qt*1.5;
                }else if(cod == 1002){
                    vl += qt*2.5;
                }else if(cod == 1003){
                    vl += qt*3.5;
                }else if(cod == 1004){
                    vl += qt*4.5;
                }else if(cod == 1005){
                    vl += qt*5.5;
                }
            }
            Console.WriteLine(vl.ToString("0.00"));
        }
    }
}

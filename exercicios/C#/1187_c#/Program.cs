using System;

namespace _1187_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            string Op = Convert.ToString(Console.ReadLine());
            double soma =0, media =0;
            int c2=0,inf =0,sup=0;

            double[,] matriz = new double[12,12];

            for(int i=0;i<12;i++){
                for(int j=0;j<12;j++){
                    double valor = Convert.ToDouble(Console.ReadLine());
                    matriz[i,j] = valor;
                }
            }
            if(Op == "S"){
                inf = 1;
                sup = 11;
                for(int i=0;i<6;i++){
                    for(int j=inf;j<sup;j++){
                        soma += matriz[i,j];
                    }
                    inf +=1;
                    sup -=1;
                }
                Console.WriteLine(soma.ToString("0.0"));
            }else if(Op == "M"){
                c2 = 0;
                inf = 1;
                sup = 11;
                for(int i=0;i<6;i++){
                    for(int j=inf;j<sup;j++){
                        soma += matriz[i,j];
                        c2 +=1;
                    }
                    inf += 1;
                    sup -= 1;
                }
                media = soma/c2;
                Console.WriteLine(media.ToString("0.0"));
            }
        }
    }
}

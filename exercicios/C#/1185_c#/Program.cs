using System;

namespace _1185_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            string Op = Convert.ToString(Console.ReadLine());
            double soma =0, media =0;
            int c=0,c2=0;

            double[,] matriz = new double[12,12];

            for(int i=0;i<12;i++){
                for(int j=0;j<12;j++){
                    double valor = Convert.ToDouble(Console.ReadLine());
                    matriz[i,j] = valor;
                }
            }
            if(Op == "S"){
                c = 11;
                for(int i=0;i<11;i++){
                    for(int j=0;j<c;j++){
                        soma += matriz[i,j];
                    }
                    c -=1;
                }
                Console.WriteLine(soma.ToString("0.0"));
            }else if(Op == "M"){
                c=11;
                c2 = 0;
                for(int i=0;i<11;i++){
                    for(int j=0;j<c;j++){
                        soma += matriz[i,j];
                        c2 +=1;
                    }
                    c-=1;
                }
                media = soma/c2;
                Console.WriteLine(media.ToString("0.0"));
            }
        }
    }
}

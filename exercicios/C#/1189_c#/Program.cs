using System;

namespace _1189_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            string Op = Convert.ToString(Console.ReadLine());
            double soma =0, media =0;
            int col=0,c2=0;

            double[,] matriz = new double[12,12];

            for(int i=0;i<12;i++){
                for(int j=0;j<12;j++){
                    double valor = Convert.ToDouble(Console.ReadLine());
                    matriz[i,j] = valor;
                }
            }
            if(Op == "S"){
                col = 1;
                for(int i=1;i<=11;i++){
                    for(int j=0;j<col;j++){
                        soma += matriz[i,j];
                    }
                    if(i<5){
                        col = col + 1;
                    }else if(i>5){
                        col = col - 1;
                    }
                }
                Console.WriteLine(soma.ToString("0.0"));
            }else if(Op == "M"){
                c2 = 0;
                col = 1;
                for(int i=1;i<=11;i++){
                    for(int j=0;j<col;j++){
                        soma += matriz[i,j];
                        c2 +=1;
                    }
                    if(i<5){
                        col = col + 1;
                    }else if(i>5){
                        col = col - 1;
                    }
                }
                media = soma/c2;
                Console.WriteLine(media.ToString("0.0"));
            }
        }
    }
}

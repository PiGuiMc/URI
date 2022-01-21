using System;

namespace _1181_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int linha = Convert.ToInt32(Console.ReadLine());
            string Op = Convert.ToString(Console.ReadLine());
            double soma=0,media=0;
            double[,] matriz = new double[12,12];

            for(int i=0;i<12;i++){
                for(int j=0;j<12;j++){
                    double valor = Convert.ToDouble(Console.ReadLine());
                    matriz[i,j] = valor;
                }
            }
            for(int k=0;k<12;k++){
                soma += matriz[linha,k];
            }
            if(Op == "S"){
                Console.WriteLine(soma.ToString("0.0"));
            }else{
                media = soma / 12;
                Console.WriteLine(media.ToString("0.0"));
            }
        }
    }
}

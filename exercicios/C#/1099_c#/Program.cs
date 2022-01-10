using System;

namespace _1099_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, maior, menor,s=0;

            n = Convert.ToInt32(Console.ReadLine());

            for(int i =0; i < n;i++){
                s = 0;
                
                String line = Console.ReadLine();
                string[] valor = line.Split(" ");
                int x = Convert.ToInt32(valor[0]);
                int y = Convert.ToInt32(valor[1]);

                if(x > y){
                    maior = x;
                    menor = y;
                }else{
                    maior = y;
                    menor = x;
                }

                for(int k = menor+1; k<maior;k++){
                    if(k%2 !=0){
                        s = s + k;
                    }
                }
                if(menor == maior){
                    s = 0;
                }
                Console.WriteLine(s);

            }
        }
    }
}

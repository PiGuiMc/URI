using System;

namespace _1158_c_
{
    class Program
    {
        static void Main(string[] args)
        {   
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<n;i++){
                string line = Console.ReadLine();
                string [] entrada = line.Split(' ');
                
                int x = Convert.ToInt32(entrada[0]);
                int y = Convert.ToInt32(entrada[1]);

                int soma =0, j =1;

                while(j<=y){
                    if(x%2 !=0){
                        soma = soma + x;

                        x = x + 1;
                        j = j +1;
                    }
                    if(x%2==0){
                        x = x + 1;
                    }
                }
                Console.WriteLine(soma);
            }

        }
    }
}

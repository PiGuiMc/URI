using System;

namespace _1179_c_
{
    class Program
    {
        static void Main(string[] args)
        {   int p=0,im=0,j=0;
            int[] par = new int[5];
            int[] impar = new int[5];
            for(int i=0;i<15;i++){

                int valor = Convert.ToInt32(Console.ReadLine());

                if(valor % 2  == 0){
                    par[p] = valor;
                    p+=1;
                }else if(valor % 2 != 0){
                    impar[im] = valor;
                    im += 1;
                }
                if(par.Length == 5 && p==5){
                    while(j<5){
                        Console.WriteLine("par[{0}] = {1}",j.ToString(),par[j].ToString());
                        j +=1;
                    }
                    j=0;
                    p = 0;
                    par = new int [5];
                }
                else if(impar.Length==5 && im == 5){
                    while(j<5){
                        Console.WriteLine("impar[{0}] = {1}",j.ToString(),impar[j].ToString());
                        j +=1;
                    }
                    j=0;
                    im = 0;
                    impar = new int [5];
                }
            }
            for (int i = 0; i < im; i++)
            {
                Console.WriteLine("impar[" + i + "] = " + impar[i]);
            }
            for (int i = 0; i < p; i++)
            {
                Console.WriteLine("par[" + i + "] = " + par[i]);
            }
        }
    }
}

using System;

namespace _1117_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont =0;
            double nota=0; 
            while(cont<2){
                
                double n = Convert.ToDouble(Console.ReadLine());

                if(n < 0 || n > 10){
                    Console.WriteLine("nota invalida");
                }else if(n >=0 && n <=10){
                    nota += n;
                    cont +=1;
                }     
            }
            Console.WriteLine("media = {0}",(nota/2).ToString("0.00"));
        }
    }
}

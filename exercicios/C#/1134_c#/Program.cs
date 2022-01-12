using System;

namespace _1134_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =0,g=0,d=0;
            while(true){
                int op = Convert.ToInt32(Console.ReadLine());

                if(op==1){
                    a+=1;
                }else if(op ==2){
                    g +=1;
                }else if(op ==3){
                    d+=1;
                }else if(op==4){
                    Console.WriteLine("MUITO OBRIGADO");
                    Console.WriteLine("Alcool: {0}",a.ToString());
                    Console.WriteLine("Gasolina: {0}",g.ToString());
                    Console.WriteLine("Diesel: {0}",d.ToString());
                    break;
                }
            }
        }
    }
}

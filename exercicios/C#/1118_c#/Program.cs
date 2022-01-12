using System;

namespace _1118_c_
{
    class Program
    {
        static void Main(string[] args)
        {  
            bool valid = true;
            while(valid == true){
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
                if(cont ==2){
                    cont = 0;
                    nota = 0;
                }

                 while(true){
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    int op = Convert.ToInt32(Console.ReadLine());
                    cont = 0;
                    if(op==2){
                        valid = false;
                        break;
                    }else if(op == 1){
                        valid = true;
                        cont = 0;
                        nota =0;
                        break;
                    }
                }
            }
        }
    }
}

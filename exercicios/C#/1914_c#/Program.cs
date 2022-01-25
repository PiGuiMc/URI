using System;

namespace _1914_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<n; i++){
                string[] line = Console.ReadLine().Split(' ');

                string p1 = line[0], op1 = line[1];
                string p2 = line[2], op2 = line[3];

                string[] valor = Console.ReadLine().Split(' ');

                int v1 = Convert.ToInt32(valor[0]), v2 = Convert.ToInt32(valor[1]);

                if((v1 + v2)%2 == 0){
                    if(op1 == "PAR"){
                        Console.WriteLine(p1);
                    }else{
                        Console.WriteLine(p2);
                    }
                }
                else if((v1+v2)%2!=0){
                    if(op1 == "IMPAR"){
                        Console.WriteLine(p1);
                    }else{
                        Console.WriteLine(p2);
                    }
                }
                
            }
        }
    }
}

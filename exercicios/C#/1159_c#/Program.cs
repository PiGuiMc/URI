using System;

namespace _1159_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                int soma =0,i=1;
                int n = Convert.ToInt32(Console.ReadLine());

                if(n ==0){
                    break;
                }
                if(n!=0){
                    while(i<=5){
                        if(n %2 ==0){
                            soma = soma + n;
                            n = n + 1;
                            i +=1;
                        }else{
                            n =n +1 ;
                        }
                    }
                    Console.WriteLine(soma);
                }
            }
        }
    }
}

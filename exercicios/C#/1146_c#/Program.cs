using System;

namespace _1146_c_
{
    class Program
    {
        static void Main(string[] args)
        {
           int n;
           int[] dados = new int[n];

           while(true){
            
               n = int.Parse(Console.ReadLine());

               if(n == 0){
                   break;
               }

               for(int i =1;i<=n;i++){
                   Add(dados[i] = i);
               }
               Console.WriteLine(dados);
           }
        }
    }
}

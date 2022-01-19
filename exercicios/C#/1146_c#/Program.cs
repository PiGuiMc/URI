using System;

namespace _1146_c_
{
    class Program
    {
        static void Main(string[] args)
        {
        
           while(true){
                int n = int.Parse(Console.ReadLine());
                string teste;
               if(n == 0){
                   break;
               }

               for(int i = 1;i<=n;i++){
                  teste = "%d " + i.ToString();
               }
           }
        }
    }
}

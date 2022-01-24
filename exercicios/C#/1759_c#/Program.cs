using System;

namespace _1759_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            string[] teste = new string[x];
            
            for(int i=0;i<x;i++){
               if(i<x-1){
                   teste[i] = "Ho";
               }else{
                   teste[i] = "Ho !";
               }
            }
            Console.WriteLine(string.Join(" ",teste));
        }
    }
}

using System;

namespace _1114_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 0;
            v = Convert.ToInt32(Console.ReadLine());
            for(int i=0;v != 2002;i++){
                if(v!=2002){
                    Console.WriteLine("Senha Invalida");
                    v = Convert.ToInt32(Console.ReadLine());
                    } 
                }
                if(v == 2002){
                    Console.WriteLine("Acesso permitido");
                }
        }
    }
}

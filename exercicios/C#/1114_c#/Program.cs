using System;

namespace _1114_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                string v = Console.ReadLine();
                if(v!="2002"){
                    Console.WriteLine("Senha Invalida");
                    }
                else if(v == "2002"){
                    Console.WriteLine("Acesso permitido");
                    break;
                }
            }
        }
    }
}

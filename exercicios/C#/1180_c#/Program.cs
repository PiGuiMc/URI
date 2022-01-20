using System;

namespace _1180_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 1000,pos=0,teste;

            int n = Convert.ToInt32(Console.ReadLine());
            
            String line = Console.ReadLine();
            String[] valor = line.Split(' ');
            for(int i=0;i<n;i++){
                teste = Convert.ToInt32(valor[i]);

                if(teste<aux){
                    aux = teste;
                    pos = i;
                }
            }
            Console.WriteLine("Menor valor: {0}",aux.ToString());
            Console.WriteLine("Posicao: {0}",pos.ToString());
        }
    }
}

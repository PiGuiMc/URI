using System;

namespace _2006_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = Convert.ToInt32(Console.ReadLine()), count=0;

            string[] valor = Console.ReadLine().Split(' ');
            int[] valores = new int[5];

            for(int i=0; i<5; i++){
                valores[i] = Convert.ToInt32(valor[i]);
            }

            for(int j=0; j<5; j++){
                if(v == valores[j]){
                    count += 1;
                }
            }

            Console.WriteLine(count);
        }
    }
}

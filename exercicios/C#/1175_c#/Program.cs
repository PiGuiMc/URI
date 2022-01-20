using System;

namespace _1175
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[100];

            for(int i=19;i>=0;i--){
                int num = Convert.ToInt32(Console.ReadLine());

                vector[i] = num;
            }
            for(int j=0;j<20;j++){
                Console.WriteLine("N[{0}] = {1}",j.ToString(),vector[j].ToString());
            }
        }
    }
}

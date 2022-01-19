using System;

namespace _1174_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vector = new double[100];

            for(int i=0;i<100;i++){
                double num = Convert.ToDouble(Console.ReadLine());

                vector[i] = num;
            }
            for(int j=0;j<100;j++){
                if(vector[j] <=10){
                    Console.WriteLine("A[{0}] = {1}",j.ToString(),vector[j].ToString("0.0"));
                }
            }
        }
    }
}

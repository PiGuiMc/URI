using System;

namespace _1116_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0;i<n;i++){
                string[] line = Console.ReadLine().Split(' ');

                double x = Convert.ToDouble(line[0]);
                double y = Convert.ToDouble(line[1]);

                if(y==0){
                    Console.WriteLine("divisao impossivel");
                }else{
                    Console.WriteLine(Convert.ToDouble(x/y).ToString("0.0"));
                }

            }
        }
    }
}

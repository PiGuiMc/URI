using System;

namespace _1865_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<n;i++){
                String[] v = Console.ReadLine().Split(' ');

                if(v[0] == "Thor"){
                    Console.WriteLine("Y");
                }else{Console.WriteLine("N");}
            }
        }
    }
}

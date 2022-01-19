using System;

namespace _1172_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<10;i++){
                int num = Convert.ToInt32(Console.ReadLine());

                if(num <=0){
                    Console.WriteLine("X[{0}] = 1",i.ToString());
                }else{Console.WriteLine("X[{0}] = {1}",i.ToString(),num.ToString());}
            }
        }
    }
}

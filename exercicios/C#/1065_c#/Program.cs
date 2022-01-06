using System;

namespace _1065_c_
{
    class Program
    {
        static void Main(string[] args)
        {   
            int count =0;
            for(int i = 0; i < 5; i++)
            {
                int v = Convert.ToInt32(Console.ReadLine());

                if(v % 2 == 0)
                {
                    count +=1; 
                }
            }
            Console.WriteLine("{0} valores pares",count.ToString());
        }
    }
}

using System;

namespace _1072_c_
{
    class Program
    {
        static void Main(string[] args)
        {   int i = 0, ent = 0, fora = 0;
            int n = Convert.ToInt32(Console.ReadLine());

            while(i < n)
            {
                int v = Convert.ToInt32(Console.ReadLine());

                if(v >= 10 && v <= 20)
                {
                    ent+=1;
                }
                else
                {
                    fora +=1;
                }

                i+=1;
            }
            Console.WriteLine("{0} in\n{1} out",ent.ToString(),fora.ToString());
        }
    }
}

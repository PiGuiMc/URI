using System;

namespace _1837_c_
{
    class Program
    {
        static void Main(string[] args)
        {   
            int q=0,r=0;
            string[] valor = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(valor[0]);
            int b = Convert.ToInt32(valor[1]);

            for(r = 0;r<(Math.Abs(b));r++){
                if(((a-r)%b)==0){
                    q =Convert.ToInt32((a-r)/b);
                    break;
                }
            }
            Console.WriteLine("{0} {1}",q,r);
        }
    }
}

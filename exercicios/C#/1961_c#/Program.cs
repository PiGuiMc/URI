using System;

namespace _1961_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag=0,sum;

            string[] valor = Console.ReadLine().Split(' ');

            int x = Convert.ToInt32(valor[0]), y = Convert.ToInt32(valor[1]);

            int[] a = new int[y];

            string[] valor2 = Console.ReadLine().Split(' ');

            for(int i=0;i<y;i++)
            {
                a[i] = Convert.ToInt32(valor2[i]);
            }

            for(int i=1;i<y;i++)
            {
                if(a[i]>a[i-1])
                sum = (a[i] - a[i-1]);
                else
                sum = (a[i-1] - a[i]);
                if(sum<=x)
                flag=1;
                else
                {
                    flag=0;
                    break;
                }
            }
            if(flag==1){
                Console.WriteLine("YOU WIN");
            }else{
                Console.WriteLine("GAME OVER");
                }
        }
    }
            
}

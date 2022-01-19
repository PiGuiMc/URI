using System;

namespace _1165_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<n;i++){

                int num = Convert.ToInt32(Console.ReadLine()),s=0,j=1;

                while(j<=num){
                    if(num%j==0){
                        s+=1;
                    }
                    j+=1;
                }
                if(s > 2){
                    Console.WriteLine("{0} nao eh primo",num);
                }else{
                    Console.WriteLine("{0} eh primo",num);
                }
            }
        }
    }
}

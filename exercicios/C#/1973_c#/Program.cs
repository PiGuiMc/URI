using System;

namespace _1973_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n= Convert.ToInt32(Console.ReadLine()),pos=0,soma=0;
            long total=0,ataques=0;
            bool continua = true;

            int[] nums = new int[n];

            string[] valor = Console.ReadLine().Split(' ');

            for(int i=0;i<n;i++){
                int num = Convert.ToInt32(valor[i]);
                nums[i] = num;
                total += num;
            }

            for(int j=0; j<n; j++){
                if(nums[j]%2==0 && continua){
                    ataques = j+1;
                    soma += ((j*2)+1) - pos;
                    continua = false;
                }
                if(nums[j] -1 == 0 && continua){
                    pos = j + 1;
                }
            }

            if(soma>0){
                total -= soma;
            }else{
                ataques = n;
                total -= ataques;
            }
           Console.WriteLine("{0} {1}",ataques,total);
        }
    }
}

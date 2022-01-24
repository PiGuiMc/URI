using System;

namespace _1789_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                string input = Console.ReadLine();
                if(string.IsNullOrEmpty(input))
                break;

                int n = Convert.ToInt32(input),m=0,op=0;

                int[] lista = new int[n];

                String[] valor = Console.ReadLine().Split(' ');

                for(int i=0;i<n;i++){
                    if(Convert.ToInt32(valor[i]) > m){
                        m = Convert.ToInt32(valor[i]);
                    }
                }
                if(m<10){
                    op = 1;
                }else if(m >= 10 && m< 20){
                    op = 2;
                }else{
                    op = 3;
                }
                Console.WriteLine(op);
            }
        }
    }
}

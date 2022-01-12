using System;

namespace _1132_c_
{
    class Program
    {
        static void Main(string[] args)
        {   
            int maior,menor,soma=0;
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if(x>y){maior=x; menor=y;}else{maior=y;menor=x;}

            for(int i = menor;i<=maior;i++){
                if(i%13!!=0){
                    soma +=i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}

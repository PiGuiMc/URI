using System;

namespace _11145_c_
{
    class Program
    {
        static void Main(string[] args)
        {
        string[] vet = Console.ReadLine().Split(' ') ;
        int x,y,count;
        x = int.Parse(vet[0]);
        y = int.Parse(vet[1]);
        count = 1;

        for (int i = 1;i <= y;i++)
        {
            Console.Write(i);
            if (x == count)
            {
                Console.WriteLine();
                count = 1;
            }
            else if(count < x)
            {
                Console.Write(" ");
                count++;

                }

            }
        }
    }
}

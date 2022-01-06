using System;

namespace _1052_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Meses = {" ","January","February","March","April","May","June","July","August","September","October","November","December"};

            int valor = Convert.ToInt32(Console.ReadLine());
            if(valor >= 1 && valor <= 12)
            {
                Console.WriteLine(Meses[valor]);
            }
        }
    }
}

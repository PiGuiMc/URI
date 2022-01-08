using System;

namespace _1098_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = 2;
            double c = 3;
            double i = 0;

            while (i <= 2.0){
                if( i == 0 || i == 1 || i > 1.8){
                    Console.WriteLine("I={0} J={1}",i.ToString(),a.ToString());
                    Console.WriteLine("I={0} J={1}",i.ToString(),b.ToString());
                    Console.WriteLine("I={0} J={1}",i.ToString(),c.ToString());
        
                }else{   
                    Console.WriteLine("I={0} J={1}",i.ToString("0.0"),a.ToString("0.0"));
                    Console.WriteLine("I={0} J={1}",i.ToString("0.0"),b.ToString("0.0"));
                    Console.WriteLine("I={0} J={1}",i.ToString("0.0"),c.ToString("0.0"));
                }
                a += 0.2;
                b += 0.2;
                c += 0.2;
                i += 0.2;
            }
        }
    }
}

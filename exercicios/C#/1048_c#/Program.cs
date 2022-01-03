using System;
using System.Globalization;
namespace _1048_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0,reajuste = 0;
            int porc = 0;
            double valor = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(valor >= 0 && valor <= 400)
            {
                reajuste = valor * 0.15;
                salario = valor + reajuste;
                porc = 15;             
            }
            else if(valor >= 400.01 && valor <= 800.00)
            {
                reajuste = valor * 0.12;
                salario = valor + reajuste;
                porc = 12;  
            }
            else if(valor >= 800.01 && valor <= 1200)
            {
                reajuste = valor * 0.10;
                salario = valor + reajuste;
                porc = 10;  
            }
            else if(valor >= 1200.01 && valor <= 2000)
            {
                reajuste = valor * 0.07;
                salario = valor + reajuste;
                porc = 7;  
            }
            else if(valor >= 2000)
            {
                reajuste = valor * 0.04;
                salario = valor + reajuste;
                porc = 4;  
            }
            Console.WriteLine("Novo salario: {0}",salario.ToString("0.00"));
            Console.WriteLine("Reajuste ganho: {0}",reajuste.ToString("0.00"));
            Console.WriteLine("Em percentual: {0} %",porc.ToString());
        }
    }
}

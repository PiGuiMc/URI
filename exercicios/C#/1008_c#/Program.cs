using System;

namespace _1008_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEmployee = Convert.ToInt16(Console.ReadLine());
            int workedHours = Convert.ToInt16(Console.ReadLine());
            double valueHours = Convert.ToDouble(Console.ReadLine());

            double salary = workedHours * valueHours;    

            Console.WriteLine("NUMBER = "+numEmployee.ToString());
            Console.WriteLine("SALARY = U$ "+ salary.ToString("0.00"));
        }
    }
}

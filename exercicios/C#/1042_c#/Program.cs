using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Demo {
   public class Program {
      public static void Main(String[] args) {
         List<int> list1 = new List<int>();
         List<int> list2 = new List<int>();
         
        
        String[] Entrada = Console.ReadLine().Split(' ');

        int A = Convert.ToInt32(Entrada[0]);
        int B = Convert.ToInt32(Entrada[1]);
        int C = Convert.ToInt32(Entrada[2]);
        list1.Add(A);
        list1.Add(B);
        list1.Add(C);

        list2.Add(A);
        list2.Add(B);
        list2.Add(C);

        
        list1.Sort();
        foreach (int x in list1)
        {
        Console.WriteLine(x);
        }

        Console.WriteLine();
        
        foreach (int x in list2)
        {
        Console.WriteLine(x);
        }
      }
   }
}
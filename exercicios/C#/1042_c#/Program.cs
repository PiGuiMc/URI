﻿using System;
using System.Collections;

public class SamplesArray  {

   public class myReverserClass : IComparer  {

      // Calls CaseInsensitiveComparer.Compare with the parameters reversed.
      int IComparer.Compare( Object x, Object y )  {
          return( (new CaseInsensitiveComparer()).Compare( y, x ) );
      }
   }

   public static void Main()  {

      // Creates and initializes a new Array and a new custom comparer.
      String[] myKeys = Console.ReadLine().Split(' ');
      String[] myValues = { "strawberries", "PEARS", "LIMES", "BERRIES", "grapes", "olives", "cantaloupe" };
      IComparer myComparer = new myReverserClass();

      // Displays the values of the Array.
      Console.WriteLine( "The Array initially contains the following values:" );
      PrintKeysAndValues( myKeys, myValues );

      // Sorts a section of the Array using the default comparer.
      Array.Sort( myKeys, myValues, 1, 3 );
      Console.WriteLine( "After sorting a section of the Array using the default comparer:" );
      PrintKeysAndValues( myKeys, myValues );

      // Sorts a section of the Array using the reverse case-insensitive comparer.
      Array.Sort( myKeys, myValues, 1, 3, myComparer );
      Console.WriteLine( "After sorting a section of the Array using the reverse case-insensitive comparer:" );
      PrintKeysAndValues( myKeys, myValues );

      // Sorts the entire Array using the default comparer.
      Array.Sort( myKeys, myValues );
      Console.WriteLine( "After sorting the entire Array using the default comparer:" );
      PrintKeysAndValues( myKeys, myValues );

      // Sorts the entire Array using the reverse case-insensitive comparer.
      Array.Sort( myKeys, myValues, myComparer );
      Console.WriteLine( "After sorting the entire Array using the reverse case-insensitive comparer:" );
      PrintKeysAndValues( myKeys, myValues );
   }

   public static void PrintKeysAndValues( String[] myKeys, String[] myValues )  {
      for ( int i = 0; i < myKeys.Length; i++ )  {
         Console.WriteLine( "   {0,-10}: {1}", myKeys[i], myValues[i] );
      }
      Console.WriteLine();
   }
}

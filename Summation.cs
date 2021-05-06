using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata 
{
    public static int summation(int num)
    { 
    // Create a var to hold the total
      var total = 0;
    // From 1 to num loop num amount of times
      for(var i = 1; i < num+1; i++)
        {
        // add i to the total each pass through the loop
          total += i;
        }
      // Return our total
      return total;
      
      // OR
      // return Enumerable.Range(1, num).Sum()
      // OR
      // return num*(num+1)/2;
    }
}

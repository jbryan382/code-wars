using System;
using System.Linq;

public class Kata
{
  public static long SuperSize(long num)
  {
//     var numString = num.ToString();
//     var orderedString = numString.OrderByDescending(number => number);
//     var joinedString = string.Concat(orderedString);
//     return long.Parse(joinedString);
    
    return long.Parse( string.Concat(num.ToString().OrderByDescending(number => number)));
  }
}

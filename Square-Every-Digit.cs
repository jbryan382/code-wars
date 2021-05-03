using System;
using System.Linq;

public class Kata
{
  public static int SquareDigits(int n)
  {
//     Convert the int to a string
    var stringInt = n.ToString();
//     Select through the string for each character convert to an int and square
//     Join the ints together, and convert back to an Int.
    var squaredString = String.Concat(stringInt.Select(character => char.GetNumericValue(character) * char.GetNumericValue(character)));
//     Return integer
    return int.Parse(squaredString);
  }
}

using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
    //     Sanitize the input provided to us to Lower case
    var sanitizedInput = input.ToLower();
//     Find, and count all the x's within the string
    var xes = sanitizedInput.Count(letter => letter == 'x');
//     Find, and count all the o's within the string
    var os = sanitizedInput.Count(letter => letter == 'o');
//     if the number of x's and o's are the same then return true
    return xes == os;
  }
}

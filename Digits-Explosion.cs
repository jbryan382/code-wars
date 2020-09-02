using System;
using System.Linq;

public class Digits
{
  public static string Explode(string s)
  {
    var expString = "";
    for (var i = 0; i < s.Length; i++)
    {
      var numChar = s[i].ToString();
      var num = Int32.Parse(numChar);
      
      for(var j = 0; j < num; j++)
      {
       expString += numChar; 
      }
    }
    return expString;
  }
}

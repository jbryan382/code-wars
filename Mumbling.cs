using System;
using System.Collections.Generic;
using System.Linq;

public class Accumul 
{
	public static String Accum(string s) 
  {
    var accumString = "";
     var charList = new List<char>(s);
    for (var i = 0; i < charList.Count; i++)
    {
      for (var j = 0; j <= i; j++)
      {
        if (j == 0)
        {
         accumString += char.ToUpper(charList[i]);  
        }
        else { 
         accumString += char.ToLower(charList[i]);
        }
      }
      if (i != charList.Count - 1)
        accumString += '-';
    }
    return accumString;
  }
}

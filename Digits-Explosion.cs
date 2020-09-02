using System;
using System.Linq;

public class Digits
{
  public static string Explode(string s)
  {
   // Creating a string to hold our exploding digits
    var expString = "";
   // I want to loop through the length of the string to alter each character
    for (var i = 0; i < s.Length; i++)
    {
   // Creating numChar to hold the char value of the variable
      var numChar = s[i].ToString();
   // Creating num to hold the int value of the variable
      var num = Int32.Parse(numChar);
   // Dependent on the number I would like to loop through and duplicate the number num number of times.
      for(var j = 0; j < num; j++)
      {
       // Each step of the way the character is added to our return string
       expString += numChar; 
      }
    }
    // Return the new exploded string to the system
    return expString;
  }
}

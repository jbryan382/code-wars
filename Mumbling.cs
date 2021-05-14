using System;

public class Accumul 
{
	public static String Accum(string s) 
  {
//   Creating a empty string to add to later on
    var accumString = "";
    
// For each character I need to capitalize the first char and duplicate the char n number of times
    for (var i = 0; i < s.Length; i++)
    {
// For each letter we will loop for i number of times increasing by 1 every loop
      for (var j = 0; j <= i; j++)
      {
// I want to check to see if the char is the first Char of the new string
        if (j == 0)
        {
// If j is 0 then it is the first time through the loop and I need to capitalize the char
         accumString += char.ToUpper(s[i]);  
        }
        else 
	{
// If it is anything higher than 0 add the lower case version to the accumString
         accumString += char.ToLower(s[i]);
        }
      }
// If the for loop hasn't reached the end of the List of Characters add a '-' to the end of the set of letters.
      if (i != s.Length - 1)
        accumString += '-';
    }
// Return the accumString back to the system.
    return accumString;
  }
}

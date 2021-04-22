public class Kata
{
  public static string TripleTrouble(string one, string two, string three)
  {
// Create a variable to hold our new outputString
    var outputString = "";
// For the length of one of the strings we will loop
    for(var index = 0; index < one.Length; index++){
// Inside the loop we will add the first Char from each string to our outputString
// We will take the char at the i index of the string
      outputString += $"{one[index]}{two[index]}{three[index]}";
      
    }
// Return our outputString
    return outputString;
    
  }
}

public class ShortLongShort
{
  public static string Solution(string a, string b)
  {
  //Get the length of string a
    var aLen = a.Length;
  //Get the length of string b
    var bLen = b.Length;
  //Compare the two lengths
  //If b is bigger than a then its aba
    if (aLen < bLen){
      return a + b + a;
  //If a is bigger than b then its bab
    } else if (bLen < aLen){
      return b + a + b;
  //Sometimes codewars thinks you're not returning so added an else null return.
    } else {
      return null;
    }
  }
}

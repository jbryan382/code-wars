using System;

public class Kata
{   
  public static string NameShuffler(string str)
  {
    var firstLast = str.Split(' ');
    var placeHolder = firstLast[0];
    firstLast[0] = firstLast[1];
    firstLast[1] = placeHolder;
    return string.Join(' ', firstLast);
//     return $"{firstLast[1]} {firstLast[0]}";
  }
}

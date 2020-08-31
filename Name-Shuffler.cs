using System;

public class Kata
{   
  public static string NameShuffler(string str)
  {
    var firstLast = str.Split(' ');
    var placeholder = firstLast[0];
    firstLast[0] = firstLast[1];
    firstLast[1] = placeholder;
    return string.Join(' ', firstLast);
  }
}

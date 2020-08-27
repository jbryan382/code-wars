using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string SpinWords(string sentence)
  {
    var forList = sentence.Split(' ');
    var splitList = new List<string>(forList);
    for (var i = 0; i < splitList.Count(); i++){
      if(splitList[i].Length >= 5)
      {
        splitList[i] = new string(splitList[i].Reverse().ToArray());
      }
    }
    return string.Join(' ', splitList.ToArray());
  }
}

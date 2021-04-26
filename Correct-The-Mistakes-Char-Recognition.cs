using System;

public class Kata
{
  public static string Correct(string text)
  {
//     Create a blank string to return the correct string
    var correctString = "";
//     For the length of the text provided determine each character
    for (var i = 0; i < text.Length; i++){
//     If the text at position i == '5' then add a S to the correct string
      if (text[i] == '5'){
        correctString += 'S';
      } else if(text[i] == '0'){
//     If the text at position i == '0' then add an O to the correct string
        correctString += 'O';
      } else if(text[i] == '1'){
//     If the text at position i == '1' then add an I to the correct string
        correctString += 'I';
      } else {
//     Any other characters will be added to the correct string as is
        correctString += text[i];
      }
    }
//     Return the correct string to the program.
    return correctString;
  }
}

// Refactor using Linq
using System;
using System.Linq;

public class Kata
{
  public static string Correct(string text)
  {
    return text.Replace("0", "O").Replace("1", "I").Replace("5","S");
  }
}


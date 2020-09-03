using System.Linq;

public class Kata
{
  public static string Well(string[] x)
  {
    var rating = x.Count(item => item.ToLower() == "good");
      if(rating > 2){
        return "I smell a series!";
      }else if (rating > 0 && rating <= 2) {
        return "Publish!";
      }
    return "Fail!";
  }
}

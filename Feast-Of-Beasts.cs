using System.Linq;

public class Kata
{
    public static bool Feast(string beast, string dish)
    {
      var firstCharBeast = beast.First();
      var lastCharBeast = beast.Last();
      var firstCharDish = dish.First();
      var lastCharDish = dish.Last();
      
      if (firstCharBeast == firstCharDish && lastCharBeast == lastCharDish)
      {
        return true;
      }
      return false;
    }
}

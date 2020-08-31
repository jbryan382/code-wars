public class Kata
{
  public static int Grow(int[] x)
  {
    var total = 1;
    for(var i = 0; i < x.Length; i++)
    {
        total = total * x[i];
    }
    return total;
  }
}

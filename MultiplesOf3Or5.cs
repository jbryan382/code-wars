public static class Kata
{
  public static int Solution(int value)
  {
    var total = 0;
    for(var i = 0; i < value; i++){
      if(i % 3 == 0 || i % 5 == 0){
        total += i;
      }
    }
    return total;
  }
}


public class DivisibleNb 
{
	public static bool isDivisible(long n, long x, long y) 
  {
		if (n % y == 0 && n % x == 0){
      return true;
    } else {
      return false;
    }
	}
}

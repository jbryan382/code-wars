using System.Linq;

public class Kata
{
  public static int FindNumber(int[] array) 
  {
//     Finding n or the length of the array + 1 accounting for the 0 index to find ASSUMED total
    var highestInt = array.Length + 1;
//     Utilizing the factorial equation for finding the facotrial of the ASSUMED maximun INT of the array given
    var assumedSumOfAllNumbers = highestInt * (highestInt + 1) / 2;
//     return the difference between the ASSUMED sum of the array and the sum (or the factorial)
//     of the given array to find the missing int
    return assumedSumOfAllNumbers - array.Sum();
  }
}

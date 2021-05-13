// https://www.codewars.com/kata/52685f7382004e774f0001f7/train/csharp

public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
//       Convert the seconds given into hours 1hr = 3600s
      var hours = seconds/3600;
//       Convert the remaining seconds to minutes 1m = 60s
      var minutes = (seconds-(hours * 3600))/60;
//       Save the remaining seconds
      var secondz = (seconds-(hours * 3600)+(minutes * 60))%60;
//       Create a string to store our hours if the hours is below 10 append a '0' before it
      string sHours = hours < 10 ? '0' + hours.ToString() : hours.ToString();
//       Create a string to store our minutes if the hours is below 10 append a '0' before it
      string sMinutes = minutes < 10 ? '0' + minutes.ToString() : minutes.ToString();
//       Create a string to store our seconds if the hours is below 10 append a '0' before it
      string sSeconds = secondz < 10 ? '0' + secondz.ToString() : secondz.ToString();
      
      return $"{sHours}:{sMinutes}:{sSeconds}";
    }
}

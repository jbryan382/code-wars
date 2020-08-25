using System;
using System.Collections.Generic;


public class Kata
{
  public static string[] TowerBuilder(int nFloors)
  {
    var tower = new List<string>();
    var count = 1;
    var spacer = nFloors - 1;
    for (var i = 1; i <= nFloors; i++){
      if (i == nFloors && nFloors != 1){
        var bottomFloor = new String('*', count);
        tower.Add(bottomFloor);
        
      } else {
        var floor = new String('*', count);
        var spacing = new String(' ', spacer);
        var finishedFloor = spacing + floor + spacing;
        count += 2;
        spacer--;
        tower.Add(finishedFloor);
      }
    }
    
    return tower.ToArray();
  }
}

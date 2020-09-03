using System;
using System.Collections.Generic;


public class Kata
{
  public static string[] TowerBuilder(int nFloors)
  {
//     I want to create a List to hold our layers of the tower
    var tower = new List<string>();
//     Setting a variable for count to ensure were counting the number of floors
    var count = 1;
//    I will need to take into account the spaces on either side of the floor *
    var spacer = nFloors - 1;
//    I want to loop through each of the floors and build out each level
    for (var i = 1; i <= nFloors; i++){
//    If the floor were building is equal to the nFloors were at the bottom and need to add the bottom floor
      if (i == nFloors && nFloors != 1){
//    I want to build out the basement of the tower creating a new string with '*' x count
        var bottomFloor = new String('*', count);
//    I want to add the bottom floor back to out tower list holding the rest of the floors
        tower.Add(bottomFloor);
//    For any floor that is not the bottom floor I will create a floor taking into account floor level and spacing
      } else {
//    I want to create a new string for the floor containing * count number of times
        var floor = new String('*', count);
//    I want to account for the spacing on either side of the *
        var spacing = new String(' ', spacer);
//    I want to combine together the spacing and the floor to complete the floor
        var finishedFloor = spacing + floor + spacing;
//    Increment our count by 2 accomodating for the additional 2 * appearing on the next level
        count += 2;
//    Decrement our spacer by one to account for the decreasing spacer as the floors get larger.
        spacer--;
//    I want to add the finished Floor to our tower List 
        tower.Add(finishedFloor);
      }
    }
// I want to return my tower List but our return type is an array of strings. string[]
    return tower.ToArray();
  }
}

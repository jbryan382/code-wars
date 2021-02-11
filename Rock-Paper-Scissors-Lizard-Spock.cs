namespace Kata {
  using System;
  public class Kata
  {
     public static string RPSLP(string player1, string player2)
     {
       if (player1 != null && player2 != null) {
       player1 = player1.ToLower();
       player2 = player2.ToLower();
      if (player1 == player2 && player1.Length != 0 && player2.Length != 0){
    return "Draw!";
    }
    else if((player1 == "scissor" && player2 == "paper") || ( player1 == "rock" && player2 == "scissor") || ( player1 == "paper" && player2 == "rock") || (player1 == "rock" && player2 == "lizard") || (player1 == "lizard" && player2 == "spock" ) || (player1 == "spock" && player2 == "scissor") || (player1 == "scissor" && player2 == "lizard") || ( player1 == "lizard" && player2 == "paper") || (player1 == "paper" && player2 == "spock") || (player1 == "spock" && player2 == "rock")){
    return "Player 1 won!";
  }
    else if((player1 == "paper" || player1 == "rock" || player1 == "scissor" || player1 == "lizard" || player1 == "spock") && (player2 == "paper" || player2 == "rock" || player2 == "scissor" || player2 == "lizard" || player2 == "spock") ) {
    return "Player 2 won!";
  }
         }
       return "Oh, Unknown Thing";
     }
  }
}

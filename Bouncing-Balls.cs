public class BouncingBall {
	
	public static int bouncingBall(double h, double bounce, double window) {
// I want to create a variable to hold our number of times the ball is seen 
      var bounceCounter = 0;
      // I had (0 < bounce < 1), but was given an error that I cannot use < on type bool and int.
// I want to make sure the height is greater than zero AND the bounce is between 0 and 1 AND the windows height is less than the height of the ball drop
	    if ((0 < h) && (bounce < 1) && (bounce > 0) && (window < h))
      {
// While the ball is bouncing we need to keep track of the amount of times the ball was visible
        while (window < h){
// The ball is traveling downward the ball will be seen once so we need to add one to our count
          bounceCounter++;
// With each bounce the height decreases 
          h = h * bounce;
// Every time the ball bounces down it bounces back up and we need to account for that.
// But what about the last bounce if it doesn't reach past the window then we can't count it.
// Once the height is changed in the while loop on the last loop the if statement wont go off because the height is less than the window.
          if(window < h){
            bounceCounter++;
          }
         }
// We want to return our counter
        return bounceCounter;
      } else {
// If the given parameters are invalid we return -1
       return -1; 
      }
	}
}

namespace Converter {
  public class Converter
  {
    public string dnaToRna(string dna)
    {
    //Created return string
      var myRNAString = "";
    //Using for loop to check each char
      for(var i = 0; i < dna.Length; i++){
    //If the char is a T add a U to the return string
        if (dna[i] == 'T'){
          myRNAString += 'U';
        } else {
    //If its any other letter just add it to the return string
          myRNAString += dna[i];
        }
      }
    //Return my completed RNA return string
      return myRNAString;
    }
  }
}

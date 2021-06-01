function decode(string) {
//   Initialize a string to return
  let returnString = ''
//   for each character in the string we will check its value
  for(let i = 0; i < string.length; i++) {
//     compare each character in a switch case
    switch(string[i]){
//         if the char is '1' add a '9' to the returnString
        case '1':
        returnString += '9'
        break;
//         if the char is '2' add a '8' to the returnString
        case '2':
        returnString += '8'
        break;
//         if the char is '3' add a '7' to the returnString.... and so on
        case '3':
        returnString += '7'
        break;
        case '4':
        returnString += '6'
        break;
        case '5':
        returnString += '0'
        break;
        case '6':
        returnString += '4'
        break;
        case '7':
        returnString += '3'
        break;
        case '8':
        returnString += '2'
        break;
        case '9':
        returnString += '1'
        break;
//         Set a default of 5 to ensure that '0''s will be swapped for a 5.
        default:
        returnString+= '5'
        break
    }
  }
//   Return the returnString
  return returnString
}

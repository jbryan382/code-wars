function wordPattern(word) {
  let placeholderArray = [];
  let splitString = word.toLowerCase().split('');
  for (let i = 0; i < splitString.length; i++){
    if(placeholderArray.includes(splitString[i]) === false){
       placeholderArray.push(splitString[i]);
    }
  }
  for (i = 0; i < splitString.length; i++){
    splitString[i] = placeholderArray.indexOf(splitString[i]);
  }
  return splitString.join('.')
}

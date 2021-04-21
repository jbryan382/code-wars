const binaryArrayToNumber = arr => { 
  return parseInt(arr.toString().replace(/,/g,""),2);
};

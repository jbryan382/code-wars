var moveZeros = function (arr) {
  if(arr){
  let theRest = arr.filter(element => element !== 0)
  let zeroes = arr.filter(element => element === 0)
  zeroes.forEach(z => theRest.push(z))
  return theRest
  }
  return arr
}

var moveZeros = function (arr) {
  let theRest = arr.filter(element => element !== 0)
  let zeroes = arr.filter(element => element === 0)
  return theRest.concat(zeroes)
  }

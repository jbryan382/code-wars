var moveZeros = function (arr) {
  return arr.filter(element => element !== 0).concat(arr.filter(element => element === 0))
  }

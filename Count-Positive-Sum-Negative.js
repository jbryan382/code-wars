function countPositivesSumNegatives(input) {
    let positive = 0
    let negative = 0
    let newArray = []
    if (input && input.length > 0){
      input.forEach(num => num > 0 ? positive++: negative += num)
      newArray.push(positive)
      newArray.push(negative)
    }
    return newArray
}

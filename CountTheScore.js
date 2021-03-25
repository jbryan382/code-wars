function scoreboard(string) {
  let scores = ['nil', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine']
  let splitString = string.split(' ')
  let filteredString = splitString.filter(word => scores.includes(word))
  return filteredString.map(number => scores.indexOf(number))
}

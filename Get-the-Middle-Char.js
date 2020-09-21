function getMiddle(s)
{
  let midWay = Math.floor(s.length/2)
  if (s.length % 2 === 0){
    return s[midWay - 1] + s[midWay]
  } else {
    return s[midWay]
  }
}

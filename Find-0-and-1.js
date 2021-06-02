// 7kyu: https://www.codewars.com/kata/57d237f25dc38ede6e00026b/train/javascript
function find01(arr) {
//   Initialize a var to hold our count
  let count = 0;
//   for the length of the arr of arrays starting at 1 (we don't care for the first row)
  for (i = 1; i < arr.length-1; i++)
//   for the length of the array within arr starting at 1 (we don't care for the first column)
    for (j = 1; j < arr[i].length-1; j++) {
//       Grab the current position within the array using the i and j respectively
      const arrPosition = arr[i][j];
//       Check to see if the index to the right and left, then above and below are not equal to what is in the arrPosition
      if (arrPosition != arr[i][j-1] && arrPosition != arr[i][j+1] && arrPosition != arr[i-1][j] && arrPosition != arr[i+1][j])
//         if the left, right, above and below are not the same character/num as the arrPosition then increase the count by 1
        count++;
    }
//   return the count
  return count;
}

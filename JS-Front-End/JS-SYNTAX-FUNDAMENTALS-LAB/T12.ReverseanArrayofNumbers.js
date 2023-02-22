function solve(place, arr) {
  let idx = place - 1;
  let result = "";
  for (let i = idx; i >= 0; i--) {
    result += `${arr[i]} `;
  }
  console.log(result);
}

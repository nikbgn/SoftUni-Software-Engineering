function solve(arr) {
  let evens = [];
  let odds = [];
  for (const item of arr) {
    if (item % 2 === 0) {
      evens.push(item);
    } else {
      odds.push(item);
    }
  }

  let evensSum = evens.reduce((a, b) => a + b, 0);
  let oddsSum = odds.reduce((a, b) => a + b, 0);

  console.log(evensSum - oddsSum);
}

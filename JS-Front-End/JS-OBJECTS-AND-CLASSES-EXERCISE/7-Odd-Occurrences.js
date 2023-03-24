function odd_occurrences(input) {
  let tracker = {};
  input.split(" ").forEach((item) => {
    let itemLowercase = item.toLowerCase();
    if (!(itemLowercase in tracker)) tracker[itemLowercase] = 1;
    else tracker[itemLowercase]++;
  });

  let out = [];
  for (const item in tracker) {
    if (!(tracker[item] % 2 === 0)) out.push(item);
  }
  console.log(out.join(" "));
}


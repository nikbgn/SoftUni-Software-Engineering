function words_tracker(input) {
  let dictionary = {};

  [first_half, ...rest] = input;
  let look_for = first_half.split(" ");

  look_for.forEach((w) => {
    dictionary[w] = 0;
  });

  rest.forEach((w) => {
    if (w in dictionary) dictionary[w]++;
  });

  let sortedDict = Object.entries(dictionary).sort((a, b) => {
    let [_a, cb] = a;
    let [_b, ca] = b;
    return ca - cb;
  });

  for (const [word, count] of sortedDict) {
    console.log(`${word} - ${count}`);
  }
}


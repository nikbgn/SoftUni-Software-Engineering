function loading_bar(percentage) {
  let isCompelete = true;
  let output = "[";
  let dots_needed = 10;
  for (let i = 0; i < percentage / 10; i++) {
    output += "%";
    dots_needed--;
  }
  if (dots_needed > 0) isCompelete = false;
  while (dots_needed > 0) {
    output += ".";
    dots_needed--;
  }
  output += "]";

  if (!isCompelete) {
    console.log(`${percentage}% ${output}`);
    console.log("Still loading...");
  } else {
    console.log("100% Complete!");
    console.log(output);
  }
}


function solve(radius) {
  if (typeof radius != "number") {
    console.log(
      `We can not calculate the circle area, because we receive a ${typeof radius}.`
    );
    return;
  }

  console.log((Math.pow(radius, 2) * Math.PI).toFixed(2));
}

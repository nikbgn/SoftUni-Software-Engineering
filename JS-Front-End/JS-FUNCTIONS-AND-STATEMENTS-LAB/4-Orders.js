function solve(product, quantity) {
  let prices = {
    coffee: 1.5,
    water: 1,
    coke: 1.4,
    snacks: 2
  };

  let price = prices[product] * quantity;
  console.log(price.toFixed(2));
}

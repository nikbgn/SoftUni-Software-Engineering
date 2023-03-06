function solve(fruit, weight, pricePerKilogram) {
    let weightInKg = weight / 1000;
    let moneyNeeded = weightInKg * pricePerKilogram;
    console.log(`I need $${moneyNeeded.toFixed(2)} to buy ${weightInKg.toFixed(2)} kilograms ${fruit}.`);
}
function solve(num1, num2, operation) {
  const multiply = (num1, num2) => num1 * num2;
  const divide = (num1, num2) => {
    if (num2 === 0) return; //Can't divide by zero
    return num1 / num2;
  };
  const add = (num1, num2) => num1 + num2;
  const subtract = (num1, num2) => num1 - num2;

  const calculator = {
    multiply: multiply,
    divide: divide,
    add: add,
    subtract: subtract,
  };

  return calculator[operation](num1, num2);
}

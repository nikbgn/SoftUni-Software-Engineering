function solve(num1, num2, operator) {
  switch (operator) {
    case "+":
      console.log(num1 + num2);
      break;
    case "-":
      console.log(num1 - num2);
      break;
    case "*":
      console.log(num1 * num2);
      break;
    case "/":
      //POSSIBLE DIVISION BY ZERO!
      console.log(num1 / num2);
      break;
    case "%":
      console.log(num1 % num2);
      break;
    case "**":
      console.log(num1 ** num2);
      break;
    default:
      break;
  }
}

function factorial_division(first_num, second_num) {
  let get_factorial = (number) => {
    let result = 1;
    for(let i = 1; i <= number; i++){
        result *= i;
    }
    return result;
  };

  let first_factorial = get_factorial(first_num);
  let second_factorial = get_factorial(second_num);

  return (first_factorial / second_factorial).toFixed(2);
}


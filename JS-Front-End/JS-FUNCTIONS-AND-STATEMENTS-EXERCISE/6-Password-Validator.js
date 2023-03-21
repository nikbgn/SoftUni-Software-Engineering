function password_validator(password) {
  let isValid = true;
  const length_validator = (password) => {
    if (password.length >= 6 && password.length <= 10) return true;
    return false;
  };

  const only_letters_and_digits_validator = (password) =>
    /^[A-Za-z0-9]*$/.test(password);

  const at_least_two_digits_validator = (password) => {
    let digitsCount = 0;
    for (let character of password) {
      if (Number.isInteger(Number(character))) digitsCount++;
    }
    return digitsCount >= 2 ? true : false;
  };

  if (!length_validator(password)) {
    console.log("Password must be between 6 and 10 characters");
    isValid = false;
  }
  if (!only_letters_and_digits_validator(password)) {
    console.log("Password must consist only of letters and digits");
    isValid = false;
  }
  if (!at_least_two_digits_validator(password)) {
    console.log("Password must have at least 2 digits");
    isValid = false;
  }
  if (isValid) console.log("Password is valid");
}

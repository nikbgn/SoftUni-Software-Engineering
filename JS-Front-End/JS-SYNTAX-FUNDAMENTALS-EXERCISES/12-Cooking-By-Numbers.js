function solve(input_number, ...operations) {
  let number = Number(input_number);
  operations.forEach((operation) => {
    switch (operation) {
      case "chop":
        number /= 2;
        break;

      case "dice":
        number = Math.sqrt(number);
        break;

      case "spice":
        number += 1;
        break;

      case "bake":
        number *= 3;
        break;

      case "fillet":
        number -= number*0.2;
        break;

      default:
        break;
    }
    console.log(number);
  });

}
